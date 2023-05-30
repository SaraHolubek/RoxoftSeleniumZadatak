using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Zadatak4
{
    internal class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        // TEST CASE ID: 1
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }
        [Test]
        public void CheckIfLoginScreenIsDisplayed()
        {
            IWebElement element = driver.FindElement(By.ClassName("login-box"));

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }



        // TEST CASE: 1.1

        [SetUp]
        public void Initialize1()
        {

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");

        }

        [Test]
        public void CheckIfKorisnickoImeIsEmpty()
        {
            IWebElement element = driver.FindElement(By.Name("user-name"));
        }

        [Test]
        public void CheckIfLozinkaIsEmpty()
        {
            IWebElement element = driver.FindElement(By.Name("password"));

        }

        [TearDown]
        public void CloseBrowser1()
        {
            driver.Close();
        }

        // TEST CASE: 1.5.1

        [SetUp]
        public void Initialize2()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Test]
        public void ClickOnButtonPrijava()
        {
            IWebElement element = driver.FindElement(By.Name("login-button"));
            element.Submit();
        }

        [Test]
        public void CheckMessageOutput()
        {
            IWebElement element = driver.FindElement(By.ClassName("error-message-container error"));

        }

        [TearDown]
        public void CloseBrowser2()
        {
            driver.Close();
        }
    }
}
