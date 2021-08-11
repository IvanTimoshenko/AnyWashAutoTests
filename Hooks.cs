using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.UnitTestProvider;

namespace AnyWashAutotests
{
    [Binding]
    /// <summary> Класс различных Hooks, выполняемых в определённый момент Specflow тестов </summary>
    class Hooks
    {
        /// <summary> Specflow Tags </summary>
        public static string[] Tags { get; private set; }

        /// <summary> Запоминаем упавшие тесты по фильтру </summary>
        public static List<string> FailedScenariosFilters { get; private set; } = new List<string>();

        // Используется для пропуска или доработки сценария.
        // Пример использования:    testProvider.TestIgnore("Причина пропуска сценария такая-то...");
        //                          testProvider.TestInconclusive("Тест находится на стадии разработки...");
        public static IUnitTestRuntimeProvider CurrentTestProvider { get; set; }

        public static TimeSpan WebDriverWait { get; set; } = TimeSpan.FromSeconds(20);

        /// <summary> Текущий WebDriver </summary>
        public static IWebDriver webDriver = new ChromeDriver();

        public static WebDriverWait Wait { get; } = new WebDriverWait(webDriver, WebDriverWait);


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            KillAllChromeDrivers();
            webDriver.Navigate().GoToUrl("https://anywash.ru");
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = WebDriverWait;
        }

        [BeforeScenario]
        static public void BeforeScenario()
        {
            webDriver.Navigate().GoToUrl("https://anywash.ru");
        }

        [BeforeStep]
        static public void BeforeStep()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
            webDriver.Quit();
        }

        [AfterTestRun]
        static public void AfterTestRun()
        {
            new Reporter("cmd", @"/k livingdoc test-assembly AnyWashAutotests.dll -t TestExecution.json");
            new Reporter("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "C:\\Users\\ivanv\\source\\repos\\AnyWashAutotests\\bin\\Debug\\netcoreapp3.1\\LivingDoc.html");

            //Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "C:\\Users\\ivanv\\source\\repos\\AnyWashAutotests\\bin\\Debug\\netcoreapp3.1\\LivingDoc.html");
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
    }
}
