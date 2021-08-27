using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnyWashAutotests.Elements
{
    public class CheckBox : Element
    {
        public CheckBox(By by) : base(by) { }

        public CheckBox(string xpath) : base(xpath) { }

        public CheckBox(IWebElement element) : base(element) { }

        public bool IsSelected(params object[] param)
        {
            return FindElement(param).Selected;
        }

        public List<IWebElement> GetAllCategoriesCheckBoxes(params object[] param)
        {
            var buttons = FindElements(param);
            var list = new List<IWebElement>();
            foreach (var el in buttons)
            {
                list.Add(el);
            }
            return list;
        }
    }
}
