using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NunitProject.Excercise07
{
    public class Test
    {
        private ChromeDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void TestMethod()
        {
            driver.Url = "http://localhost/litecart/admin";
            driver.FindElement(By.Name("username")).SendKeys("admin");
            driver.FindElement(By.Name("password")).SendKeys("admin");
            driver.FindElement(By.Name("login")).Click();

            driver.FindElement(By.CssSelector("#app-:nth-child(1) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-logotype")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(2) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-product_groups")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-option_groups")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-manufacturers")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-suppliers")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-delivery_statuses")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-sold_out_statuses")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-quantity_units")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-csv")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(3) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#app-:nth-child(4) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(5) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-csv")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-newsletter")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(6) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#app-:nth-child(7) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-storage_encoding")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(8) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-customer")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-shipping")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-payment")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-order_total")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-order_success")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-order_action")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(9) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-order_statuses")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(10) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#app-:nth-child(11) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-most_sold_products")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-most_shopping_customers")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(12) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-defaults")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-general")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-listings")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-images")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-checkout")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-advanced")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-security")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(13) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#app-:nth-child(14) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-tax_rates")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(15) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-scan")).Click();
            Assert.IsTrue(IsH1ElementPresent());
            driver.FindElement(By.CssSelector("#doc-csv")).Click();
            Assert.IsTrue(IsH1ElementPresent());

            driver.FindElement(By.CssSelector("#app-:nth-child(16) a")).Click();
            Assert.IsTrue(IsH1ElementPresent());
        }

        private bool IsH1ElementPresent()
        {
            try
            {
                driver.FindElement(By.CssSelector("h1"));
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
