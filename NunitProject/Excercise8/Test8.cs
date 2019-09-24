using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitProject.Excercise8
{
    public class Test8
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
            driver.Url = "http://localhost/litecart/en/";

            var productTile = driver.FindElements(By.CssSelector("div.image-wrapper"));

            foreach (IWebElement tile in productTile)
            {
                int stickNumber = tile.FindElements(By.CssSelector("div.sticker")).Count;
                Assert.AreEqual(1, stickNumber);
            }


        }

        [TearDown]
        public void Stop()
        {
            driver.Quit();
        }
    }
}
