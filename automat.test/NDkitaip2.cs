using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automat.test
{
    internal class NDkitaip2
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://testpages.herokuapp.com/styled/calculator";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }
        [Test]
        public static void TestSumBlock1()
        {
            
            IWebElement firstInput = _driver.FindElement(By.Id("number1"));
            IWebElement secondInput = _driver.FindElement(By.Id("number2"));

            firstInput.Clear();
            firstInput.SendKeys("2");
            secondInput.Clear();
            secondInput.SendKeys("2");

            IWebElement calculateButton = _driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", actualResult.Text, "Sum is Incorrect");            
        }
        [Test]
        public static void TestSumBlock2()
        {
            
            IWebElement firstInput = _driver.FindElement(By.Id("number1"));
            IWebElement secondInput = _driver.FindElement(By.Id("number2"));

            firstInput.Clear();
            firstInput.SendKeys("2");
            secondInput.Clear();
            secondInput.SendKeys("2");

            IWebElement calculateButton = _driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", actualResult.Text, "Sum is Incorrect");
        }
        [Test]
        public static void TestSumBlock3()
        {
            
            IWebElement firstInput = _driver.FindElement(By.Id("number1"));
            IWebElement secondInput = _driver.FindElement(By.Id("number2"));

            firstInput.Clear();
            firstInput.SendKeys("2");
            secondInput.Clear();
            secondInput.SendKeys("2");

            IWebElement calculateButton = _driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", actualResult.Text, "Sum is Incorrect");
        }
    }
}
