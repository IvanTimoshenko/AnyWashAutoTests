using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    /// <summary>
    /// Класс Page Object - Меню ЛК партнера
    /// </summary>
    public class PartnerMainPage
    {
        /// <summary> Лого AnyWash - переход на главную страницу </summary>
        public static Button BtnMainPage { get; } = new Button("//header/a[@href='//anywash.ru']");

        /// <summary> Элемент для открытия окна интерфейса автомойки </summary>
        public static Button BtnCategoryWashing { get; } = new Button("//div/a/h5[text()='Мойка']");

        /// <summary> Элемент для открытия окна интерфеса шиномонтажа </summary>
        public static Button BtnCategoryTireFitting { get; } = new Button("//div/a/h5[text()='Шиномонтаж']");

        /// <summary> Кнопка "Выйти" </summary>
        public static Button BtnExit { get; } = new Button("//footer/a[text()='Выйти']");
    }
}
