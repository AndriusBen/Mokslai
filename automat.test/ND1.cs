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
    internal class ND1
    {
        [Test]
        public static void CheckResult2Plas2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstNumber = driver.FindElement(By.Id("number1"));
            firstNumber.SendKeys("2");

            IWebElement secondNumber = driver.FindElement(By.Id("number2"));
            secondNumber.SendKeys("2");

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("4", result.Text, "blogas atsakymas");

            driver.Close();
        }

        [Test]
        public static void checkResultMinus5Plas3()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstNumber = driver.FindElement(By.Id("number1"));
            firstNumber.SendKeys("-5");

            IWebElement secondNumber = driver.FindElement(By.Id("number2"));
            secondNumber.SendKeys("3");

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("-2", result.Text, "blogas atsakymas");

            driver.Close();
        }

        [Test]
        public static void checkResultaPlasb()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://testpages.herokuapp.com/styled/calculator";

            IWebElement firstNumber = driver.FindElement(By.Id("number1"));
            firstNumber.SendKeys("a");

            IWebElement secondNumber = driver.FindElement(By.Id("number2"));
            secondNumber.SendKeys("b");

            IWebElement submitButton = driver.FindElement(By.Id("calculate"));
            submitButton.Click();

            IWebElement result = driver.FindElement(By.Id("answer"));
            Assert.AreEqual("ERR", result.Text, "blogas atsakymas");

            driver.Close();
        }
    }
}
