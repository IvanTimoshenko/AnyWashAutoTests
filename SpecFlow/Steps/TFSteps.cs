using AnyWashAutotests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AnyWashAutotests.SpecFlow.Steps
{
    [Binding]
    public sealed class TFSteps
    {
        [Given(@"Клик по кнопке вход для _клиентов")]
        public void ДопустимКликПоКнопкеВходДля_Клиентов()
        {
            //открываем меню авторизации
            DefaultPage.BtnClientLogIn.Click();
        }

        [Given(@"Авторизация в тестовый аккаунт _мойки")]
        public void ДопустимАвторизацияВТестовыйАккаунт_Мойки()
        {
            //Ввод логина
            PartnerLogInPage.InputName.FindElement().SendKeys(Config.PartnerLogin);
            //Ввод пароля
            PartnerLogInPage.InputPassword.FindElement().SendKeys(Config.PartnerPassword);
            //Клик по кнопке войти
            PartnerLogInPage.BtnLogIn.Click();
        }

        [Given(@"Клик по кнопке Шиномонтаж")]
        public void ДопустимКликПоКнопкеШиномонтаж()
        {
            PartnerMainPage.BtnCategoryTireFitting.Click();
        }

        [Given(@"Проверка паттерна")]
        public void ДопустимПроверкаПаттерна()
        {
            //проверяем, совпадает ли заданный паттерн поля текущему
            Assert.AreEqual(TireFittingPage.PatternCarNumberField, TireFittingPage.ElPatternCarNumber.FindElement().GetAttribute("pattern"));
        }

        [Given(@"Выбор случайного типа услуги шинка")]
        public void ДопустимВыборСлучайногоТипаУслугиШинка()
        {
            //получаем список доступных услуг
            var cats = TireFittingPage.AllDisplayedButtons.GetAllCategoriesButtons();
            //получаем список чек-боксов услуг
            var checkBoxes = TireFittingPage.AllDisplayedCheckBoxes.GetAllCategoriesCheckBoxes();
            //проверяем соответсвия количества услуг\чекбоксов
            Assert.IsTrue(cats.Count == checkBoxes.Count);
            //получаем количество выбираемых услуг
            int length = new Randomizer().Randomize(cats.Count - (cats.Count - 1) , cats.Count - 1);
            var indexes = new List<int>();
            indexes.Add(new Randomizer().Randomize(cats.Count));
            int temp;
            int index;
            for (int i = 0; i < length; i++)
            {
                index = new Randomizer().Randomize(cats.Count);
                for (int j = 0; j < length; j++)
                {
                    if (index == indexes[j])
                    {
                        i--;
                        continue;
                    }
                }
                cats[i].Click();
                temp = index;
                Assert.IsTrue(checkBoxes[i].Selected);
            }
        }

        [Given(@"Клик по кнопке Сбросить")]
        public void ДопустимКликПоКнопкеСбросить()
        {
            TireFittingPage.BtnReset.Click();
        }

        [Given(@"Проверка очистки полей")]
        public void ДопустимПроверкаОчисткиПолей()
        {
            //получаем список чек-боксов доступных услуг
            var checkBoxes = TireFittingPage.AllDisplayedCheckBoxes.GetAllCategoriesCheckBoxes();
            foreach (var el in checkBoxes)
            {
                Assert.IsFalse(el.Selected);
            }
        }
    }
}
