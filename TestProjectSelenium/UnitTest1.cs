using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Drawing;
using OpenQA.Selenium.Firefox;
using TestProjectSelenium.PageObjects;

namespace TestProjectSelenium
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver("C:\\Users\\vegap\\source\\repos\\TestProjectSelenium\\TestProjectSelenium\\Drivers\\");

        }

        //[Test]
        //public void testdemo()
        //{
        //    driver.Url = "http://www.google.com";
        //    driver.Url = "http://demo.guru99.com/test/guru99home/";
        //    driver.Manage().Window.Maximize();

        //    // Store locator values of email text box and sign up button				
        //    IWebElement emailTextBox = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
        //    IWebElement signUpButton = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

        //    emailTextBox.SendKeys("test123@gmail.com");
        //    signUpButton.Click();
        //    driver.Url = "http://demo.guru99.com/test/guru99home/";
        //    IWebElement course = driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

        //    var selectTest = new SelectElement(course);
        //    // Select a value from the dropdown				
        //    selectTest.SelectByValue("sap-abap");
        //    driver.Navigate().GoToUrl("https://www.demoqa.com");
        //    driver.Navigate().Back();
        //    driver.Navigate().Forward();
        //    driver.Navigate().Refresh();
        //    string title = driver.Title;
        //    String PageURL = driver.Url;
        //    IWebElement element = driver.findElement(By.Id("UserName"));
        //    element.Clear();
        //    element.SendKeys("ToolsQA");
        //    IWebElement element = driver.FindElement(By.LinkText("ToolsQA"));
        //    element.Click();
        //    bool status = element.Displayed; //is element displayed?
        //    status = element.Enabled;
        //    String attValue = element.GetAttribute("id");
        //    Point point = element.Location; //x,y coordinates
        //}

        [Test]       
        public void NunitSeleniumTest()
        {
           
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com";

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);
            fluentWait.Until(driver => driver.Title == "Google");

            HomePage hp = new HomePage(driver);         


            hp.SearchBoxClick();
            hp.SearchBoxType("selenium");
            var label = hp.getButtonText();

            fluentWait.Timeout = TimeSpan.FromSeconds(5);

        }



        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            
        }

        [OneTimeTearDown]
        public void quit()
        {
            driver.Quit();
        }
    }
}