using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Zadatak3
{
    internal class Program
    {

        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://ljekarna.hr/");
            Console.WriteLine("Otvoren URL");

        }

        [Test]
        public void ExecuteTest()
        {
            IWebElement element = driver.FindElement(By.Name("search_query"));


            element.SendKeys("Krema");
            Console.WriteLine("Izvrsen test");

        }



        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            Console.WriteLine("Zatvoren browser!!!");
        }








    }
}
