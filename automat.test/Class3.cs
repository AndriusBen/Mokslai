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
    internal class Class3
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

        [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
        [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
        [TestCase("a", "b", "ERR", TestName = "a + b = ERR")]
        public static void TestSumBlock(string firstInputvalue, string secondInputValue, string expectedResult)
        {
            IWebElement firstInput = _driver.FindElement(By.Id("number1"));
            IWebElement secondInput = _driver.FindElement(By.Id("number2"));

            firstInput.Clear();
            firstInput.SendKeys(firstInputvalue);
            secondInput.Clear();
            secondInput.SendKeys(secondInputValue);

            IWebElement calculateButton = _driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedResult, actualResult.Text, "Sum is Incorrect");
        }

    }
}
