using AnyWashAutotests.Elements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Pages
{
    public class DefaultPage
    {
        /// <summary> Кнопка "Вход для клиентов" </summary>
        public static Button BtnClientLogIn = new Button(By.XPath("//div/section[1]//a[@href='https://anywash.info']"));
    }
}
