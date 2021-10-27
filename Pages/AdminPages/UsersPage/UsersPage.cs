using AnyWashAutotests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages.AdminPages.UsersPage
{
    public class UsersPage
    {
        public static string CurrentUrl { get; } = "https://anywash.info/users";


        public static Button BtnCreateNewUser { get; } = new Button("//div/a[@href='/add/']");

        /// <summary>
        /// Путь ко всем элементам "Редактировать"
        /// </summary>
        public static Button BtnAllEditButtons { get; } = new Button("//tr/td/div/a");

        /// <summary>
        /// Путь ко всем элементам "Удалить"
        /// </summary>
        public static Button BtnAllDeleteButtons { get; } = new Button("//tr/td/div/div/a");
    }
}
