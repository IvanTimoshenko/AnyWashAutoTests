using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    public class TireFittingPage
    {
        /// <summary> Кнопка "Назад" </summary>
        public static Button BtnBackToCategories { get; } = new Button("//a[@class='back-to-cats']");

        /// <summary> Поле ввода гос. номера </summary>
        public static Input InputCarNumber { get; } = new Input("//input[@id='number']");

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
    }
}
