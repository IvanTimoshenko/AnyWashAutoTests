using AnyWashAutotests.Utils;
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
        public static TimeSpan WebDriverWait { get; set; } = TimeSpan.FromSeconds(20);

        /// <summary> Текущий WebDriver </summary>
        public static WebDriver WebDriver { get; set; }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            WebDriver.KillAllChromeDrivers();
        }

        [BeforeScenario]
        static public void BeforeScenario()
        {
            WebDriver = new WebDriver();
        }

        [BeforeStep]
        static public void BeforeStep()
        {

        }

        [AfterScenario]
        public void AfterScenario()
        {
            WebDriver.Quit();
        }

        [AfterTestRun]
        static public void AfterTestRun()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd";
            psi.Arguments = @"/k livingdoc test-assembly AnyWashAutotests.dll -t TestExecution.json";
            Process.Start(psi);
        }

        
    }
}
