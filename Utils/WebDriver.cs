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
            Wait = new WebDriverWait(Driver, Config.WebDriverWait);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(Config.MainPageURL);
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

        /// <summary>
        /// Метод для переключение на новую вкладку
        /// </summary>
        /// <param name="oldTab"> старая вкладка </param>
        public void SwitchToNewHandle(string oldTab)
        {
            var handles = new List<string>(Driver.WindowHandles);
            handles.Remove(oldTab);
            Driver.SwitchTo().Window(handles[0]);
        }
    }
}
