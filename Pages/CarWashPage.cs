using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    class CarWashPage
    {
        /// <summary> Поле для ввода гос. номера </summary>
        public static Input InputCarNumber { get; } = new Input("//input[@id='number']");

        /// <summary> Элемент для создания объекта класса "SelectElement" </summary>
        public static Element ElMainSelectWashMode { get; } = new Element("//select[@id='modeSelect']");

        /// <summary> Элемент, содержащий все типы услуг из выпадающего списка без показателя пустоты </summary>
        public static Element ElModeSelectList { get; } = new Element("//select[@id='modeSelect']/option[not(contains(text(), 'Выберите вид мойки'))]");

        /// <summary> Поле ввода номера телефона </summary>
        public static Input InputPhoneNumber { get; } = new Input("//input[@type='tel']");

        /// <summary> Кнопка "Запросить" </summary>
        public static Button BtnRequest { get; } = new Button("//button[@type='submit']");

        /// <summary> Кнопка "Сбросить" </summary>
        public static Button BtnReset { get; } = new Button("//div[@class='d-flex flex-wrap']/a[1]");

        /// <summary> Кнопка "Промокод" </summary>
        public static Button BtnPromoCode { get; } = new Button("//div[@class='d-flex flex-wrap']/a[2]");

        /// <summary> Поле для ввода промокода </summary>
        public static Input InputPromoCode { get; } = new Input("//input[@id='coupon']");

        /// <summary> Кнопка "Х" - закрытие поля промокода </summary>
        public static Button BtnClosePromoCode { get; } = new Button("//*[local-name()='svg'][@data-icon='times']");

        /// <summary> Кнопка "Транзакции" </summary>
        public static Button BtnTransactions { get; } = new Button("//a[@href='/historynew']");

        /// <summary> Кнопка "Выйти" </summary>
        public static Button BtnExit { get; } = new Button("//footer/a[text()='Выйти']");

        /// <summary> Сообщение с ошибкой об отсутствии машины в системе </summary>
        public static Element AlertCarIsNotExist { get; } = new Element("//div[contains(text(), 'Такой машины нет. Проверьте номер.')]");

        /// <summary> Xpath к паттерну поля ввода гос. номера </summary>
        public static Element ElPatternCarNumber { get; } = new Element("//input[@pattern and @id='number']");

        /// <summary> Паттерн проверки корректности ввода в поле гос. номера </summary>
        public static string PatternCarNumberField { get; } = "^[ABEWVKMNPRSHOUCTYXАВЕКМНОРСТУХabewvkmnprshouctyxавекмнорстух]{1,2}\\d{3}([DABEWVKMNPRSHOUCTYXАВЕКМНОРСТУХabewvkmnprshouctyxавекмнорстух]{1,2})?\\d{2,3} *$";
    }
}
