using AnyWashAutotests.Pages;
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
            PartnerMainPage.ElCategoryTireFitting.Click();
        }

    }
}
