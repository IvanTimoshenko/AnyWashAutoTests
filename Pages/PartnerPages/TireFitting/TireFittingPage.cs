using AnyWashAutotests.Elements;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    /// <summary>
    /// Класс Page Object - Меню шиномонтажа
    /// </summary>
    public class TireFittingPage : PartnerMainPage
    {
        /// <summary> Кнопка "Назад" </summary>
        public static Button BtnBackToCategories { get; } = new Button("//a[@class='back-to-cats']");

        /// <summary> Поле ввода гос. номера </summary>
        public static Input InputCarNumber { get; } = new Input("//input[@id='number']");

        /// <summary> Заблокированное поле ввода гос. номера </summary>
        public static Input InputCarNumberDisabled { get; } = new Input("//input[@disabled and @id='number']");

        /// <summary> XPath ко всем доступным услугам </summary>
        public static Button AllDisplayedButtons { get; } = new Button("//div[@class='form-check form-item-box ']");

        /// <summary> XPath ко всем чек-боксам доступных услуг </summary>
        public static CheckBox AllDisplayedCheckBoxes { get; } = new CheckBox("//input[@type='checkbox']");

        /// <summary> Путь к элементу с паттерном поля ввода гос. номера </summary>
        public static Element ElPatternCarNumber { get; } = new Element("//input[@pattern and @id='number']");

        /// <summary> Паттерн поля ввода гос. номера </summary>
        public static string PatternCarNumberField { get; } = "^[ABEWVKMNPRSHOUCTYXАВЕКМНОРСТУХabewvkmnprshouctyxавекмнорстух]{1,2}\\d{3}([DABEWVKMNPRSHOUCTYXАВЕКМНОРСТУХabewvkmnprshouctyxавекмнорстух]{1,2})?\\d{2,3} *$";

        /// <summary> Елемент для создания объекта класса "Select" для количества колес </summary>
        public static Select SelectNumberOfWheels { get; } = new Select("//select[@id='wheelsSelect']");

        /// <summary> Элемент, содержащий путь ко всем элементам количества колес без показателя пустоты </summary>
        public static Select SelectNumberOfWheelsList { get; } = new Select("//select[@id='wheelsSelect']/option[not(@disabled)]");

        /// <summary> Елемент для создания объекта класса "Select" для радиуса </summary>
        public static Select SelectRadiusOfWheels{ get; } = new Select("//select[@id='radiusSelect']");

        /// <summary> Элемент, содержащий путь ко всем элементам радиуса колеса без показателя пустоты </summary>
        public static Select SelectRadiusOfWheelsList { get; } = new Select("//select[@id='radiusSelect']/option[not(@disabled)]");

        /// <summary> Кнопка "Запросить" </summary>
        public static Button BtnSubmit { get; } = new Button("//button[@type='submit']");

        /// <summary> Кнопка "Сбросить" </summary>
        public static Button BtnReset { get; } = new Button("//div/a[text()='Сбросить']");

        /// <summary> Кнопка "Промокоды" </summary>
        public static Button BtnPromoCode { get; } = new Button("//div/a[text()='Промокод']");

        /// <summary> Кнопка "Транзакции" </summary>
        public static Button BtnTransactions { get; } = new Button("//div/a[@href='/historynew']");

        /// <summary> Поле ввода номера телефона </summary>
        public static Input InputPhoneNumber { get; } = new Input("//input[@type='tel']");

        /// <summary> Поле ввода промокода </summary>
        public static Input InputPromoCode { get; } = new Input("//input[@id='coupon']");

        /// <summary> Кнопка "Х" - закрытия поля промокодов </summary>
        public static Button BtnClosePromoCodeField { get; } = new Button("//*[local-name()='svg'][@data-icon='times']");

        /// <summary> Сообщение с ошибкой об отсутствии машины в системе </summary>
        public static Element AlertCarIsNotExist { get; } = new Element("//div[contains(text(), 'Такой машины нет. Проверьте номер.')]");

        /*
        /// <summary> Кнопка "Демонтаж монтаж" </summary>
        public static Button BtnDismounting_Mounting { get; } = new Button("//div/label[@for='tireService-0']");

        /// <summary> Чек-бокс "Демонтаж монтаж" </summary>
        public static CheckBox ChBoxDismounting_Mounting { get; } = new CheckBox("//input[@type='checkbox' and @id='tireService-0']");

        /// <summary> Кнопка "Устранение прокола (вулканизация)" </summary>
        public static Button BtnCuring { get; } = new Button("//div/label[@for='tireService-1']");

        /// <summary> Чек-бокс "Устранение прокола (вулканизация)" </summary>
        public static CheckBox ChBoxCuring { get; } = new CheckBox("//input[@type='checkbox' and @id='tireService-1']");

        /// <summary> Кнопка "Снятие Установка" </summary>
        public static Button BtnPullOf_Set { get; } = new Button("//div/label[@for='tireService-2']");

        /// <summary> Чек-бокс "Снятие Установка" </summary>
        public static CheckBox ChBoxPullOf_Set { get; } = new CheckBox("//input[@type='checkbox' and @id='tireService-2']");

        /// <summary> Кнопка "Балансировка" </summary>
        public static Button BtnBalancing { get; } = new Button("//div/label[@for='tireService-3']");

        /// <summary> Чек-бокс "Балансировка" </summary>
        public static CheckBox ChBoxBalancing { get; } = new CheckBox("//input[@type='checkbox' and @id='tireService-3']");

        /// <summary> Кнопка "Устранение прокола (Жгут)" </summary>
        public static Button BtnHarness { get; } = new Button("//div/label[@for='tireService-4']");

        /// <summary> Чек-бокс "Устранение прокола (Жгут)" </summary>
        public static CheckBox ChBoxHarness { get; } = new CheckBox("//input[@type='checkbox' and @id='tireService-4']");

        /// <summary> Кнопка "Сезонный шиномонтаж" </summary>
        public static Button BtnSeasonalTireService { get; } = new Button("//div/label[@for='tireService-5']");

        /// <summary> Чек-бокс "Сезонный шиномонтаж" </summary>
        public static CheckBox ChBoxSeasonalTireService { get; } = new CheckBox("//input[@type='checkbox' and @id='tireService-5']");
        */



    }
}
