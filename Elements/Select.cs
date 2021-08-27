using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Elements
{
    public class Select : Element
    {
        public Select(By by) : base(by) { }

        public Select(string xpath) : base(xpath) { }

        public Select(IWebElement element) : base(element) { }


        /// <summary> Метод для выбора пункта из выпадающего списка </summary>
        /// <param name="param"> Параметры для параметризованного XPath </param>
        /// <returns></returns>
        public SelectElement SelectDropDownList(params object[] param)
        {
            return new SelectElement(GetElement(GetByLocator(param)));
        }

        /// <summary> Получает элемент </summary>
        /// <param name="param"> Параметры для параметризированного XPath </param>
        /// <returns> IWebElement </returns>
        private IWebElement GetElement(params object[] param)
        {
            return Hooks.WebDriver.Wait.Until(ExpectedConditions.ElementExists(GetByLocator(param)));
        }
    }
}
