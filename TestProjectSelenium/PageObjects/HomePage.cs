using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;

namespace TestProjectSelenium.PageObjects
{
    internal class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //[FindsBy(How = How.Name, Using = "q")]
        //public IWebElement MyAccount { get; set; }

        private IWebElement SearchBox
        {
            get
            {
                return this.driver.FindElement(By.Name("q"));
            }
        }
        private IWebElement LuckyButton
        {
            get
            {
                return this.driver.FindElement(By.Name("btnI"));
            }
        }
       

        public void SearchBoxClick()
        {
            SearchBox.Click();
            //return this;
        }

        public void SearchBoxType(string searchQuery)
        {
            SearchBox.SendKeys(searchQuery);
            //return this;
        }
        public string getButtonText()
        {
            return LuckyButton.GetAttribute("value");
        }

    }
}
