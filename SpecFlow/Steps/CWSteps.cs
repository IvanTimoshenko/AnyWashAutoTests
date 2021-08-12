using AnyWashAutotests.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using LivingDoc.SpecFlowPlugin;

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

        [Given(@"Ввод гос номера")]
        public void ДопустимВводГос_Номера()
        {
            //Получаем случайный гос. номер
            string requiredCarNumber = new Randomizer().GetRandomCarNumber(Config.CarNumbers);
            //Передаем гос. номер в поле ввода
            CarWashPage.InputCarNumber.FindElement().SendKeys(requiredCarNumber);
            //Проверяем введенные данные
            Assert.AreEqual(requiredCarNumber, CarWashPage.InputCarNumber.FindElement().GetAttribute("value").ToString());
        }

        [Given(@"Выбор типа услуги")]
        public void ДопустимВыборТипаУслуги()
        {
            //Рандомно вибираем тип услуги
            CarWashPage.ElModeSelectList.SelectDropDownList().SelectByText(new Randomizer().GetRandomWashMode(CarWashPage.WashModeList));
        }

        [Given(@"Выполнение сброса и проверка")]
        public void ДопустимВыполнениеСбросаИПроверка()
        {
            string required = string.Empty;
            CarWashPage.BtnReset.Click();
            Assert.AreEqual(required, CarWashPage.InputCarNumber.FindElement().GetAttribute("value"));
        }

        [Given(@"Клик по кнопке промокоды")]
        public void ДопустимКликПоКнопкеПромокоды()
        {
            CarWashPage.BtnPromoCode.Click();
        }

        [Given(@"Проверка появления поля")]
        public void ДопустимПроверкаПоявленияПоля()
        {
            CarWashPage.InputPromoCode.FindElement();
        }

        [Given(@"Клик по кнопке Х")]
        public void ДопустимКликПоКнопкеХ()
        {
            CarWashPage.BtnClosePromoCode.Click();
        }

        [Given(@"Проверка закрытия поля")]
        public void ДопустимПроверкаЗакрытияПоля()
        {
            CarWashPage.InputPromoCode.ElementDisappear();
        }

        [Given(@"Ввод тестового госномера")]
        public void ДопустимВводТестовогоГосномера()
        {
            ///Вводим случайный гос. номер из списка
            CarWashPage.InputCarNumber.FindElement().SendKeys(new Randomizer().GetRandomCarNumber(Config.CarNumbers));
        }

        [Given(@"Выбор случайного типа услуги, запросить")]
        public void ДопустимВыборСлучайногоТипаУслугиЗапросить()
        {
            ///выбираем случайный тип услуги
            CarWashPage.ElModeSelectList.SelectDropDownList().SelectByText(new Randomizer().GetRandomWashMode(CarWashPage.WashModeList));
            ///клик по кнопке "Запросить"
            CarWashPage.BtnRequest.Click();
        }

        [Given(@"Проверка открытия поля ввода номера телефона")]
        public void ДопустимПроверкаОткрытияПоляВводаНомераТелефона()
        {
            CarWashPage.InputPhoneNumber.FindElement();
        }

    }
}

