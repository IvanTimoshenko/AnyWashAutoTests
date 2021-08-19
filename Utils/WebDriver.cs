using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AnyWashAutotests.Utils
{
    class WebDriver
    {
        public IWebDriver Driver { get; }
        public WebDriverWait Wait { get; }

        public WebDriver()
        {
            KillAllChromeDrivers();
            
            Driver = new ChromeDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            Wait = new WebDriverWait(Driver, Config.WebDriverWait);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://anywash.ru");
        }

        public static void KillAllChromeDrivers()
        {
            foreach (Process proc in Process.GetProcessesByName("chromedriver"))
            {
                try
                {
                    proc.Kill();
                }
                catch (Exception) { }
            }
        }
        /// <summary> Закрыть браузер </summary>
        public void Quit()
        {
            Driver.Quit();
        }
    }
}
