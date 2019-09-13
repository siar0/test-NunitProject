using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NunitProject
{
    public class UnitTest1
    {
        [TestFixture]
        public class MyFirstTest
        {
            private WebDriverWait wait;
            private IWebDriver driver;

            [SetUp]
            public void Start()
            {
                driver = new ChromeDriver();
            }

            [Test]
            public void FirstTest()
            {
                driver.Url = "http://www.google.com/";
            }

            [TearDown]
            public void Stop()
            {
                driver.Quit();
            }
        }
    }
}