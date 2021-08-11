using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    /// <summary> Класс объектов страницы авторизации Клиента "https://anywash.info " </summary>
    public class PartnerLogInPage
    {
        /// <summary> Поле ввода логина </summary>
        public static Input InputName { get; } = new Input("//input[@id='name']");
        /// <summary> Поле ввода пароля </summary>
        public static Input InputPassword { get; } = new Input("//input[@id='password']");
        /// <summary> Кнопка "Войти" </summary>
        public static Button BtnLogIn { get; } = new Button("//button[@type='submit']");
        /// <summary> Элемент с лого "AnyWash" для перехода на главную страницу </summary>
        public static Element ElemMainPage { get; } = new Element("//a[@href='//anywash.ru']");
    }
}
