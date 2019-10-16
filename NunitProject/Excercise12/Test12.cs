using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace NunitProject.Excercise12
{
    [TestFixture]
    public class Test12
    {
        private ChromeDriver driver;
        public Test12()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMethod()
        {
            LoginAdminUser();
            driver.Url = "http://localhost/litecart/admin/?app=catalog&doc=catalog";
            driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/a[2]")).Click();
            var productName = FillGeneralTab();
            driver.FindElement(By.XPath("//*[@id=\"content\"]/form/div/ul/li[2]/a")).Click();
            FillInformationTab();
            driver.FindElement(By.XPath("//*[@id=\"content\"]/form/div/ul/li[4]/a")).Click();
            FillPricesTab();
            Assert.IsTrue(IsProductAdded(productName));
            
        }

        public void LoginAdminUser()
        {
            driver.Url = "http://localhost/litecart/admin";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();
        }
        public string FillGeneralTab()
        {
            var generatedName = GenerateRandomProductName();
            driver.FindElement(By.Name("status")).Click();
            driver.FindElement(By.Name("name[en]")).SendKeys(generatedName);
            driver.FindElement(By.Name("code")).SendKeys("code1");
            driver.FindElement(By.XPath("//*[@id=\"tab-general\"]/table/tbody/tr[7]/td/div/table/tbody/tr[3]/td[1]/input")).Click();
            driver.FindElement(By.Name("quantity")).SendKeys("10");
            driver.FindElement(By.Name("date_valid_from")).SendKeys("10122020");
            driver.FindElement(By.Name("date_valid_to")).SendKeys("10122021");
            return generatedName;
        }

        public void FillInformationTab()
        {
            var manufacturerDropDown = driver.FindElement(By.Name("manufacturer_id"));
            var selectElement = new SelectElement(manufacturerDropDown);
            selectElement.SelectByValue("1");
            driver.FindElement(By.Name("keywords")).SendKeys("product1");
            driver.FindElement(By.Name("short_description[en]")).SendKeys("test description");
            driver.FindElement(By.CssSelector(".trumbowyg-editor")).SendKeys("test long description");
            driver.FindElement(By.Name("head_title[en]")).SendKeys("head title test");
            driver.FindElement(By.Name("meta_description[en]")).SendKeys("meta_description test");
            
        }

        public void FillPricesTab()
        {
            driver.FindElement(By.Name("purchase_price")).SendKeys("1111");
            var currencyDropDown = driver.FindElement(By.Name("purchase_price_currency_code"));
            var currecnyElement = new SelectElement(currencyDropDown);
            currecnyElement.SelectByValue("USD");
            driver.FindElement(By.Name("prices[USD]")).SendKeys("100");
            driver.FindElement(By.Name("save")).Click();
        }

        public string GenerateRandomProductName()
        {
            var random = new Random();
            int randomNumber = random.Next();
            return $"my_product_{randomNumber}";
        }

        private bool IsProductAdded(string expededProductName)
        {
            try
            {
                driver.FindElement(By.XPath($"//a[contains(text(),'{expededProductName}')]"));
                return true;
            }
            catch (NoSuchElementException ex)
            {
                return false;
            }
        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
        }
    }
}
