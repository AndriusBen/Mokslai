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
    internal class NDkitaip
    {
        [Test]
        public static void TestSumBlock1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            IWebElement secondInput = driver.FindElement(By.Id("number2"));

            firstInput.Clear();
            firstInput.SendKeys("2");
            secondInput.Clear();
            secondInput.SendKeys("2");

            IWebElement calculateButton = driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement actualResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", actualResult.Text, "Sum is Incorrect");

            driver.Close();
        }

    }
}
