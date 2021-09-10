using AnyWashAutotests.Elements;
using AnyWashAutotests.Pages;
using AnyWashAutotests.Pages.PartnerPages.TireFitting;
using AnyWashAutotests.Utils;
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

        [Given(@"Выбор случайного типа услуг шинка")]
        public void ДопустимВыборСлучайногоТипаУслугШинка()
        {
            //получаем список доступных услуг
            var cats = TireFittingPage.AllDisplayedButtons.FindElements();
            //получаем список чек-боксов услуг
            var checkBoxes = TireFittingPage.AllDisplayedCheckBoxes.FindElements();
            //проверяем соответсвия количества услуг\чекбоксов
            Assert.IsTrue(cats.Count == checkBoxes.Count);
            //получаем количество выбираемых услуг
            int length = new Random().Next(1, cats.Count);
            var indexes = new List<int>();
            //получаем индексы услуг
            for (int i = 0; i < length; i++)
            {
                int index;
                bool alreadyExist = false;
                index = new Randomizer().Randomize(cats.Count);
                if (i == 0) //добавляем первый индекс
                {
                    indexes.Add(index);
                    continue;
                }
                for (int j = 0; j < indexes.Count; j++) //проверяем, не совпадает ли новый индекс с предыдущими
                {
                    if (indexes[j] == index)
                    {
                        alreadyExist = true;
                        break;
                    }
                }
                if (alreadyExist)
                {
                    i--;
                    continue;
                }
                indexes.Add(index);
            }
            //кликаем по кнопкам услуг и проверяем, активны ли выбранные услуги
            for (int i = 0; i < indexes.Count; i++)
            {
                cats[indexes[i]].Click();
                Assert.IsTrue(checkBoxes[indexes[i]].Selected);
            }
        }

        [Given(@"Выбор случайного количества и радиуса колес")]
        public void ДопустимВыборСлучайногоКоличестваИРадиусаКолес()
        {
            var selectWheels = TireFittingPage.SelectNumberOfWheels;
            var selectRadius = TireFittingPage.SelectRadiusOfWheels;
            //получаем индекс случайной услуги
            int wheelsIndex = new Randomizer().GetRandomService(TireFittingPage.SelectNumberOfWheelsList.FindElements());
            int radiusIndex = new Randomizer().GetRandomService(TireFittingPage.SelectRadiusOfWheelsList.FindElements());
            //Выбираем услугу по индексу
            selectWheels.SelectDropDownList(wheelsIndex);
            selectRadius.SelectDropDownList(radiusIndex);
            //проверяем, что услуга выбрана
            Assert.IsTrue(selectWheels.IsSelected(selectWheels, wheelsIndex));
            Assert.IsTrue(selectRadius.IsSelected(selectRadius, radiusIndex));
        }

        [Given(@"Клик по кнопке Промокоды шинка")]
        public void ДопустимКликПоКнопкеПромокодыШинка()
        {
            TireFittingPage.BtnPromoCode.Click();
        }

        [Given(@"Проверка открытия поля ввода промокодов шинка")]
        public void ДопустимПроверкаОткрытияПоляВводаПромокодовШинка()
        {
            TireFittingPage.InputPromoCode.IsDisplayed();
        }


        [Given(@"Клик по кнопке Сбросить шинка")]
        public void ДопустимКликПоКнопкеСброситьШинка()
        {
            TireFittingPage.BtnReset.Click();
        }

        [Given(@"Проверка очистки поля ввода госномера")]
        public void ДопустимПроверкаОчисткиПоляВводаГосномера()
        {
            //проверяем очистку поля ввода гос. номера
            Assert.AreEqual(string.Empty, TireFittingPage.InputCarNumber.FindElement().GetAttribute("value"));
        }

        [Given(@"Ввод тестового госномера шинка")]
        public void ДопустимВводТестовогоГосномераШинка()
        {
            string plate = new Randomizer().GetRandomCarNumber(Config.CarNumbers);
            TireFittingPage.InputCarNumber.FindElement().SendKeys(plate);
            Assert.AreEqual(plate, TireFittingPage.InputCarNumber.FindElement().GetAttribute("value"));
        }


        [Given(@"Проверка очистки выбранных услуг шинка")]
        public void ДопустимПроверкаОчисткиВыбранныхУслугШинка()
        {
            //получаем список чек-боксов доступных услуг
            var checkBoxes = TireFittingPage.AllDisplayedCheckBoxes.FindElements();
            foreach (var el in checkBoxes)
            {
                //проверяем, что услуги сброшены
                Assert.IsFalse(el.Selected);
            }
        }

        [Given(@"Проверка очистки выбранного количества колес и радиуса")]
        public void ДопустимПроверкаОчисткиВыбранногоКоличестваКолесИРадиуса()
        {
            //проверяем, что количество колес и радиус сброшен
            var select = TireFittingPage.SelectNumberOfWheels;
            Assert.IsTrue(select.IsSelected(select));
            select = TireFittingPage.SelectRadiusOfWheels;
            Assert.IsTrue(select.IsSelected(select));
        }

        [Given(@"Клик по кнопке Запросить шинка")]
        public void ДопустимКликПоКнопкеЗапроситьШинка()
        {
            TireFittingPage.BtnSubmit.Click();
        }

        [Given(@"Проверка открытия поля ввода номера телефона шинка")]
        public void ДопустимПроверкаОткрытияПоляВводаНомераТелефонаШинка()
        {
            Assert.IsTrue(TireFittingPage.InputPhoneNumber.IsDisplayed());
        }

        [Given(@"Проверка закрытия поля ввода номера телефона")]
        public void ДопустимПроверкаЗакрытияПоляВводаНомераТелефона()
        {
            Assert.IsFalse(TireFittingPage.InputPhoneNumber.Exist());
        }


        [Given(@"Клик по кнопке Х, закрытие поля ввода промокодов")]
        public void ДопустимКликПоКнопкеХЗакрытиеПоляВводаПромокодов()
        {
            TireFittingPage.BtnClosePromoCodeField.Click();
        }

        [Given(@"Проверка закрытия поля ввода промокодов")]
        public void ДопустимПроверкаЗакрытияПоляВводаПромокодов()
        {
            Assert.IsFalse(TireFittingPage.BtnClosePromoCodeField.Exist());
        }

        [Given(@"Клик по кнопке Транзакции шинка")]
        public void ДопустимКликПоКнопкеТранзакцииШинка()
        {
            TireFittingPage.BtnTransactions.Click();
        }

        [Given(@"Проверка открытия страницы Транзакций")]
        public void ДопустимПроверкаОткрытияСтраницыТранзакций()
        {
            Assert.IsTrue(TireFittingTransactionsPage.ElTransactionsTable.IsDisplayed());
        }

        [Given(@"Возврат на страницу ЛК")]
        public void ДопустимВозвратНаСтраницуЛК()
        {
            Hooks.WebDriver.Driver.Navigate().Back();
        }

        [Given(@"Проверка нахождения на странице ЛК")]
        public void ДопустимПроверкаНахожденияНаСтраницеЛК()
        {
            Assert.IsTrue(PartnerMainPage.BtnCategoryTireFitting.IsDisplayed());
        }

        [Given(@"Ввод случайно сгенерированного госномера шинка")]
        public void ДопустимВводСлучайноСгенерированногоГосномераШинка()
        {
            TireFittingPage.InputCarNumber.FindElement().SendKeys(new CarNumberGenerator().GetRandomCarNumber());
        }

        [Given(@"Проверка появления сообщения с ошибкой отсутствия машины в системе шинка")]
        public void ДопустимПроверкаПоявленияСообщенияСОшибкойОтсутствияМашиныВСистемеШинка()
        {
            Assert.IsTrue(TireFittingPage.AlertCarIsNotExist.IsDisplayed());
        }

        [Given(@"Проверка блокировки полей ввода госномера и услуг шинка")]
        public void ДопустимПроверкаБлокировкиПолейВводаГосномераИУслугШинка()
        {
            ///список с XPath для одного элемента
            var unitList = new List<string>() { TireFittingPage.InputCarNumber.Xpath, TireFittingPage.SelectNumberOfWheels.Xpath,
                TireFittingPage.SelectRadiusOfWheels.Xpath };

            foreach (var el in unitList)
            {
                Assert.IsTrue(new Element(el).IsHided(true));
            }
            Assert.IsTrue(TireFittingPage.AllDisplayedCheckBoxes.IsHided(true));
        }

        [Given(@"Проверка разблокировки полей ввода госномера и услуг шинка")]
        public void ДопустимПроверкаРазблокировкиПолейВводаГосномераИУслугШинка()
        {
            ///список с XPath для одного элемента
            var unitList = new List<string>() { TireFittingPage.InputCarNumber.Xpath, TireFittingPage.SelectNumberOfWheels.Xpath,
                TireFittingPage.SelectRadiusOfWheels.Xpath };

            foreach (var el in unitList)
            {
                Assert.IsFalse(new Element(el).IsHided(false));
            }
            Assert.IsFalse(TireFittingPage.AllDisplayedCheckBoxes.IsHided(false));
        }
    }
}
