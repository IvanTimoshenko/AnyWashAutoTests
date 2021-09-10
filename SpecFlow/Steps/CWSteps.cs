using AnyWashAutotests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using AnyWashAutotests.Utils;
using OpenQA.Selenium;
using System.Collections.Generic;
using AnyWashAutotests.Elements;

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

        [Given(@"Клик по кнопке Мойка")]
        public void ДопустимКликПоКнопкеМойка()
        {
            //выбираем интерфейс автомойки
            PartnerMainPage.BtnCategoryWashing.Click();
        }

        [Given(@"Выбор типа услуги")]
        public void ДопустимВыборТипаУслуги()
        {
            var select = CarWashPage.SelectWashMode;
            //получаем индекс случайной услуги
            int washModeIndex = new Randomizer().GetRandomService(CarWashPage.SelectWashModeList.FindElements());
            //Выбираем услугу по индексу
            select.SelectDropDownList(washModeIndex);
            //проверяем, что услуга выбрана
            Assert.IsTrue(select.IsSelected(select, washModeIndex));
        }

        [Given(@"Клик по кнопке Сбросить мойка")]
        public void ДопустимКликПоКнопкеСброситьМойка()
        {
            CarWashPage.BtnReset.Click();
        }

        [Given(@"Проверка очистки поля ввода госномера мойка")]
        public void ДопустимПроверкаОчисткиПоляВводаГосномераМойка()
        {
            Assert.AreEqual(string.Empty, CarWashPage.InputCarNumber.FindElement().GetAttribute("value"));
        }

        [Given(@"Проверка очистки поля выбора услуги мойка")]
        public void ДопустимПроверкаОчисткиПоляВыбораУслугиМойка()
        {
            var select = CarWashPage.SelectWashMode;
            Assert.IsTrue(select.IsSelected(select));
        }

        [Given(@"Выполнение сброса и проверка двух полей")]
        public void ДопустимВыполнениеСбросаИПроверкаДвухПолей()
        {
            CarWashPage.BtnReset.Click();
            Assert.AreEqual(string.Empty, CarWashPage.InputCarNumber.FindElement().GetAttribute("value"));
            Assert.IsFalse(CarWashPage.InputPhoneNumber.Exist());
            var select = CarWashPage.SelectWashMode;
            Assert.IsTrue(select.IsSelected(select));
        }

        [Given(@"Клик по кнопке промокоды мойка")]
        public void ДопустимКликПоКнопкеПромокодыМойка()
        {
            CarWashPage.BtnPromoCode.Click();
        }

        [Given(@"Клик по кнопке Х мойка")]
        public void ДопустимКликПоКнопкеХМойка()
        {
            CarWashPage.BtnClosePromoCode.Click();
        }

        [Given(@"Ввод тестового госномера")]
        public void ДопустимВводТестовогоГосномера()
        {
            //получаем случайный гос. номер
            var plate = new Randomizer().GetRandomCarNumber(Config.CarNumbers);
            //Вводим случайный гос. номер
            CarWashPage.InputCarNumber.FindElement().SendKeys(plate);
            //Проверяем введенные данные
            Assert.AreEqual(plate, CarWashPage.InputCarNumber.FindElement().GetAttribute("value"));
        }

        [Given(@"Проверка соответствия паттерна поля ввода гос\. номера")]
        public void ДопустимПроверкаСоответствияПаттернаПоляВводаГос_Номера()
        {
            //проверяем, совпадает ли заданный паттерн поля текущему
            Assert.AreEqual(CarWashPage.PatternCarNumberField, CarWashPage.ElPatternCarNumber.FindElement().GetAttribute("pattern"));
        }


        [Given(@"Проверка появления поля промокоды мойка")]
        public void ДопустимПроверкаПоявленияПоляПромокодыМойка()
        {
            Assert.IsTrue(CarWashPage.InputPromoCode.Exist());
        }

        [Given(@"Проверка закрытия поля промокоды мойка")]
        public void ДопустимПроверкаЗакрытияПоляПромокодыМойка()
        {
            Assert.IsFalse(CarWashPage.InputPromoCode.Exist());
        }

        [Given(@"Запросить")]
        public void ДопустимЗапросить()
        {
            CarWashPage.BtnRequest.Click();
        }

        [Given(@"Проверка открытия поля ввода номера телефона мойка")]
        public void ДопустимПроверкаОткрытияПоляВводаНомераТелефонаМойка()
        {
            Assert.IsTrue(CarWashPage.InputPhoneNumber.IsDisplayed());
        }

        [Given(@"Проверка закрытия поля ввода номера телефона мойка")]
        public void ДопустимПроверкаЗакрытияПоляВводаНомераТелефонаМойка()
        {
            Assert.IsFalse(CarWashPage.InputPhoneNumber.Exist());
        }

        [Given(@"Клик по кнопке транзакции")]
        public void ДопустимКликПоКнопкеТранзакции()
        {
            CarWashPage.BtnTransactions.Click();
        }

        [Given(@"Проверка открытия страницы транзакций")]
        public void ДопустимПроверкаОткрытияСтраницыТранзакций()
        {
            Assert.IsTrue(CarWashTransactionsPage.ElTransactionsTable.IsDisplayed());
        }

        [Given(@"Возврат на страницу интерфейса мойки")]
        public void ДопустимВозвратНаСтраницуИнтерфейсаМойки()
        {
            Hooks.WebDriver.Driver.Navigate().Back();
            Assert.IsTrue(PartnerMainPage.BtnCategoryWashing.IsDisplayed());
        }


        [Given(@"Проверка открытия поля ввода номера телефона положит")]
        public void ДопустимПроверкаОткрытияПоляВводаНомераТелефонаПоложит()
        {
            Assert.IsTrue(CarWashPage.InputPhoneNumber.IsDisplayed());
        }

        [Given(@"Ввод случайно сгенерированного госномера")]
        public void ДопустимВводСлучайноСгенерированногоГосномера()
        {
            CarWashPage.InputCarNumber.FindElement().SendKeys(new CarNumberGenerator().GetRandomCarNumber());
        }

        [Given(@"Проверка появления сообщения с ошибкой отсутствия машины в системе")]
        public void ДопустимПроверкаПоявленияСообщенияСОшибкойОтсутствияМашиныВСистеме()
        {
            Assert.IsTrue(CarWashPage.AlertCarIsNotExist.IsDisplayed());
        }

        [Given(@"Проверка блокировки полей ввода госномера и услуг мойка")]
        public void ДопустимПроверкаБлокировкиПолейВводаГосномераИУслугМойка()
        {
            ///список с XPath для одного элемента
            var unitList = new List<string>() { CarWashPage.InputCarNumber.Xpath, CarWashPage.SelectWashMode.Xpath };

            foreach (var el in unitList)
            {
                Assert.IsTrue(new Element(el).IsHided(true));
            }
        }

        [Given(@"Проверка разблокировки полей ввода госномера и услуг мойка")]
        public void ДопустимПроверкаРазблокировкиПолейВводаГосномераИУслугМойка()
        {
            ///список с XPath для одного элемента
            var unitList = new List<string>() { CarWashPage.InputCarNumber.Xpath, CarWashPage.SelectWashMode.Xpath };

            foreach (var el in unitList)
            {
                Assert.IsFalse(new Element(el).IsHided(false));
            }
        }

    }
}

