using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTests
{
    [TestFixture]
    public class ElementsTests
    {
        IWebDriver driver = new ChromeDriver("C:\\Webdrivers\\chromedriver-win64\\chromedriver.exe");

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://demoqa.com/");
        }

        [OneTimeTearDown] 
        public void Teardown() 
        {
            Thread.Sleep(5000);
            driver.Close();
        }

        [Test]
        public void textBox()
        {
            IWebElement elements = driver.FindElement(By.ClassName("card"));
            elements.Click();
        }
    }
}