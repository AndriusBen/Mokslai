using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat.test
{
    internal class Class2
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com";
            driver.Close();
        }

        [Test]
        public static void TestFirefoxDrive()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://login.yahoo.com/";
            driver.Close();
        }

        [Test]
        public static void TestYahooPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com/";

            IWebElement emeilInputnField = driver.FindElement(By.Id("login-username"));
            emeilInputnField.SendKeys("labas@labas.lt");

            IWebElement submitButton = driver.FindElement(By.Id("login-signin"));
            submitButton.Click();
        }

        [Test]
        public static void TestInputPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys("Andrius Ben");

            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();

            IWebElement fullNameResult = driver.FindElement(By.Id("name"));
            Assert.AreEqual("Name:Andrius Ben", fullNameResult.Text, "Name is wrong!");

           driver.Close();
        }



    }
}
