using AnyWashAutotests.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using AnyWashAutotests.Utils;

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
            //Берем основной элемент выпадающего списка
            CarWashPage.SelectWashMode.SelectDropDownList().SelectByIndex(
                //получаем случайный индекс услуги
                new Randomizer().GetRandomWashMode(CarWashPage.SelectWashModeList.FindElements()));
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
            Assert.IsFalse(CarWashPage.InputPhoneNumber.Exist());
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
            //получаем случайный гос. номер
            var plate = new Randomizer().GetRandomCarNumber(Config.CarNumbers);
            //Вводим случайный гос. номер из списка
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


        [Given(@"Проверка появления поля промокоды")]
        public void ДопустимПроверкаПоявленияПоляПромокоды()
        {
            Assert.IsTrue(CarWashPage.InputPromoCode.Exist());
        }

        [Given(@"Проверка закрытия поля промокоды")]
        public void ДопустимПроверкаЗакрытияПоляПромокоды()
        {
            Assert.IsFalse(CarWashPage.InputPromoCode.Exist());
        }

        [Given(@"Запросить")]
        public void ДопустимЗапросить()
        {
            CarWashPage.BtnRequest.Click();
        }

        [Given(@"Выполнение сброса и проверка полей ввода и промокодов")]
        public void ДопустимВыполнениеСбросаИПроверкаПолейВводаИПромокодов()
        {
            CarWashPage.BtnReset.Click();
            Assert.AreEqual(string.Empty, CarWashPage.InputCarNumber.FindElement().GetAttribute("value"));
            Assert.IsFalse(CarWashPage.InputPromoCode.Exist());
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


    }
}

