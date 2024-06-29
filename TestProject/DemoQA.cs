using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        [OneTimeTearDown] 
        public void Teardown() 
        {
            driver.Dispose();
        }

        [Test]
        public void Test1()
        {

        }
    }
}