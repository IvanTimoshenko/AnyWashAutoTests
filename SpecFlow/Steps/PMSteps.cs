using AnyWashAutotests.Pages;
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
    public sealed class PMSteps
    {
        [Given(@"Клик по кнопке Вход для Клиентов_")]
        public void ДопустимКликПоКнопкеВходДляКлиентов_()
        {
            //открываем меню авторизации
            DefaultPage.BtnClientLogIn.Click();
        }

        [Given(@"Авторизация в тестовый аккаунт мойки_")]
        public void ДопустимАвторизацияВТестовыйАккаунтМойки_()
        {
            //Ввод логина
            PartnerLogInPage.InputName.FindElement().SendKeys(Config.PartnerLogin);
            //Ввод пароля
            PartnerLogInPage.InputPassword.FindElement().SendKeys(Config.PartnerPassword);
            //Клик по кнопке войти
            PartnerLogInPage.BtnLogIn.Click();
        }

        [Given(@"Клик по кнопке Выйти")]
        public void ДопустимКликПоКнопкеВыйти()
        {
            PartnerMainPage.BtnExit.Click();
        }

        [Given(@"Проверка нахождения на странице авторизации")]
        public void ДопустимПроверкаНахожденияНаСтраницеАвторизации()
        {
            Assert.IsTrue(PartnerLogInPage.InputName.IsDisplayed());
        }

        [Given(@"Проверка открытия интерфейса автомойки")]
        public void ДопустимПроверкаОткрытияИнтерфейсаАвтомойки()
        {
            Assert.IsTrue(CarWashPage.InputCarNumber.IsDisplayed());
        }

        [Given(@"Проверка открытия интерфейса шиномонтажа")]
        public void ДопустимПроверкаОткрытияИнтерфейсаШиномонтажа()
        {
            Assert.IsTrue(TireFittingPage.InputCarNumber.IsDisplayed());
        }

        [Given(@"Клик по Лого AnyWash")]
        public void ДопустимКликПоЛогоAnyWash()
        {
            PartnerMainPage.BtnMainPage.Click();
        }

        [Given(@"Проверка открытия главной страницы")]
        public void ДопустимПроверкаОткрытияГлавнойСтраницы()
        {
            Hooks.WebDriver.SwitchToNewHandle(Hooks.WebDriver.Driver.CurrentWindowHandle);
            Assert.AreEqual(Config.MainPageURL, Hooks.WebDriver.Driver.Url);
        }

    }
}
