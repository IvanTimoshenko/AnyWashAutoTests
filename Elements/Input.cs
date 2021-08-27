using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Elements
{
    public class Input : Element
    {
        public Input(By by) : base(by) { }

        public Input(string xpath) : base(xpath) { }

        public Input(IWebElement element) : base(element) { }

        /// <summary> Чистим поле </summary>
        public void ClearField(params object[] param)
        {
            var el = FindElement(param);
            var textLength = el.GetAttribute("value").Length;
            for (var i = 0; i < textLength; i++)
                el.SendKeys(Keys.Backspace);
        }
    }
}
