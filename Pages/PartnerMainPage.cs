using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    public class PartnerMainPage
    {
        /// <summary> Элемент для открытия окна интерфейса автомойки </summary>
        public static Button ElCategoryWashing { get; } = new Button("//div/a/h5[text()='Мойка']");

        /// <summary> Элемент для открытия окна интерфеса шиномонтажа </summary>
        public static Button ElCategoryTireFitting { get; } = new Button("//div/a/h5[text()='Шиномонтаж']");

        /// <summary> Кнопка "Выйти" </summary>
        public static Button BtnExit { get; } = new Button("//footer/a[text()='Выйти']");
    }
}
