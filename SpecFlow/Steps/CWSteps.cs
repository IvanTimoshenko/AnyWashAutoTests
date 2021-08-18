using AnyWashAutotests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using LivingDoc.SpecFlowPlugin;
using AnyWashAutotests.Elements;
using OpenQA.Selenium.Support.UI;

namespace AnyWashAutotests.Steps
{
    [Binding]
    public sealed class CWSteps
    {

        [Given(@"Клик по кнопке Вход для Клиентов")]
        public void ДопустимКликПоКнопкеВходДляКлиентов()
        {
            //открываем меню авторизации
            DefaultPage.BtnClientLogIn.Click();
        }

        [Given(@"Авторизация в тестовый аккаунт мойки")]
        public void ДопустимАвторизацияВТестовыйАккаунтМойки()
        {
            //Ввод логина
            PartnerLogInPage.InputName.FindElement().SendKeys(Config.PartnerLogin);
            //Ввод пароля
            PartnerLogInPage.InputPassword.FindElement().SendKeys(Config.PartnerPassword);
            //Клик по кнопке войти
            PartnerLogInPage.BtnLogIn.Click();
        }


        [Given(@"Выбор типа услуги")]
        public void ДопустимВыборТипаУслуги()
        {
            //Рандомно вибираем тип услуги
            
            new SelectElement(CarWashPage.MainSelectWashMode.FindElement()).SelectByIndex(
                new Random().Next(1, CarWashPage.ElModeSelectList.FindElements().Count));
        }

        [Given(@"Выполнение сброса и проверка")]
        public void ДопустимВыполнениеСбросаИПроверка()
        {
            CarWashPage.BtnReset.Click();
            Assert.AreEqual(string.Empty, CarWashPage.InputCarNumber.FindElement().GetAttribute("value"));
        }

        [Given(@"Выполнение сброса и проверка двух полей")]
        public void ДопустимВыполнениеСбросаИПроверкаДвухПолей()
        {
            CarWashPage.BtnReset.Click();
            Assert.AreEqual(string.Empty, CarWashPage.InputCarNumber.FindElement().GetAttribute("value"));
            bool required = false;
            Assert.AreEqual(required, CarWashPage.InputPhoneNumber.Exist());
        }

        [Given(@"Клик по кнопке промокоды")]
        public void ДопустимКликПоКнопкеПромокоды()
        {
            CarWashPage.BtnPromoCode.Click();
        }

        [Given(@"Клик по кнопке Х")]
        public void ДопустимКликПоКнопкеХ()
        {
            CarWashPage.BtnClosePromoCode.Click();
        }

        [Given(@"Ввод тестового госномера")]
        public void ДопустимВводТестовогоГосномера()
        {
            ///Вводим случайный гос. номер из списка
            CarWashPage.InputCarNumber.FindElement().SendKeys(new Randomizer().GetRandomCarNumber(Config.CarNumbers));
        }


        [Given(@"Проверка открытия поля ввода номера телефона")]
        public void ДопустимПроверкаОткрытияПоляВводаНомераТелефона()
        {
            bool required = false;
            Assert.AreEqual(required, CarWashPage.InputPhoneNumber.Exist());
        }

        [Given(@"Проверка появления поля промокоды")]
        public void ДопустимПроверкаПоявленияПоляПромокоды()
        {
            bool required = true;
            Assert.AreEqual(required, CarWashPage.InputPromoCode.Exist());
        }

        [Given(@"Проверка закрытия поля промокоды")]
        public void ДопустимПроверкаЗакрытияПоляПромокоды()
        {
            bool required = false;
            Assert.AreEqual(required, CarWashPage.InputPromoCode.Exist());
        }

        [Given(@"Запросить")]
        public void ДопустимЗапросить()
        {
            CarWashPage.BtnRequest.Click();
        }


    }
}

