using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace automat.test
{
    internal class Class5
    {
        private static IWebDriver _driver;
        

        [OneTimeSetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demoqa.com/checkbox";

            IWebElement popUp = _driver.FindElement(By.Id("close-fixedban"));
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(x => popUp.Displayed);
            Thread.Sleep(5000); //kai reikia daugiau laiko palaukti
            popUp.Click();

            IWebElement expandAllButton = _driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
            expandAllButton.Click();

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public static void CheckAllCheckBoxes(string firstInputValue, string secondInputValue, bool shouldBeChecked, string result)
        {
            IReadOnlyCollection<IWebElement> checkBoxes = _driver.FindElements(By.ClassName("rct-checkbox"));

           foreach (IWebElement checkBox in checkBoxes)

            {

                checkBox.Click();

            }
        }
    }
}
