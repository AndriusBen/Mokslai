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
    internal class piguLT
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://pigu.lt/lt/";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            //driver.Close();
        }
        [Test]
        public static void CloseCokies()
        {
            IWebElement popUp = driver.FindElement(By.CssSelector("#cookie_block > div > div > div.cookies_action > button"));

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(x => popUp.Displayed);

           // Thread.Sleep(5000); //kai reikia daugiau laiko palaukti
            popUp.Click();
        }

    }
}
//Baigiamojo darbo reikalavimai:

//Minimum 5 prasmingi testai(kiekvienas testas minimum 3 žingsniai)
//Minimum 3 skirtingi puslapiai(tas pats website)
//Page Object Pattern
//Screenshot on test failure
//Paveldėjimas
//SetUp / TearDown panaudojimas
//Darbas įkeltas į GIT
//Explicit Wait panaudojimas
