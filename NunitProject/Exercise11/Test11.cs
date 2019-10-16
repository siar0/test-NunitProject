using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NunitProject.Exercise11
{
    public class Test11
    {
        private ChromeDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
            driver.Url = "http://localhost/litecart/en/create_account";
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
        }

        [Test]
        public void TestMethod()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            var useremail = GenerateRandomEmail();
            FillrequiredFields(useremail);
            driver.FindElement(By.Name("create_account")).Click();
            driver.FindElement(By.XPath("//*[@id=\"box-account\"]/div/ul/li[4]/a")).Click();
            driver.FindElement(By.Name("email")).SendKeys(useremail);
            driver.FindElement(By.Name("password")).SendKeys("Test123");
            driver.FindElement(By.Name("login")).Click();
            driver.FindElement(By.XPath("//*[@id=\"box-account\"]/div/ul/li[4]/a")).Click();
        }
        
        public void FillrequiredFields(string userEmail)
        {
            driver.FindElement(By.Name("firstname")).SendKeys("Jan");
            driver.FindElement(By.Name("lastname")).SendKeys("Kovalsky");
            driver.FindElement(By.Name("address1")).SendKeys("Zamkowa");
            driver.FindElement(By.Name("postcode")).SendKeys("01-400");
            driver.FindElement(By.Name("city")).SendKeys("Warszawa");
            driver.FindElement(By.Name("email")).SendKeys(userEmail);
            driver.FindElement(By.Name("phone")).SendKeys("123123123");
            driver.FindElement(By.Name("password")).SendKeys("Test123");
            driver.FindElement(By.Name("confirmed_password")).SendKeys("Test123");
        }

        public string GenerateRandomEmail()
        {
            var random = new Random();
            int randomNumber = random.Next();
            return $"test.email{randomNumber}@wp.pl";
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
        }
    }
}
