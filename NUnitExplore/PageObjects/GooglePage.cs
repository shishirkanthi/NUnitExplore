using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;

namespace NUnitExplore.PageObjects
{
    class GooglePage:BasePage
    {

        public IWebElement txtSearchBox => driver.FindElements(By.CssSelector("#lst-ib")).FirstOrDefault();
        public IWebElement btnSearh => driver.FindElements(By.CssSelector("[name='btnK'],.lsb")).FirstOrDefault(btn => btn.Displayed);
        public IWebElement lblLogoSubtext => driver.FindElements(By.CssSelector(".logo-subtext")).FirstOrDefault();
        public List<IWebElement> resultsList => driver.FindElements(By.CssSelector("h3")).ToList();


        //public GooglePage(IWebDriver driver)
        //{

        //    base.driver = driver;
        //    PageFactory.InitElements(base.driver, this);
        //}
        //[FindsBy(How =How.CssSelector , Using = "#lst-ib")]
        //public IWebElement txtSearchBox { get; set; }


        //[FindsBy(How = How.CssSelector, Using = "[name='btnK'],.lsb")]
        //public IWebElement btnSearh { get; set; }



        //[FindsBy(How = How.CssSelector, Using = "h3")]
        //public IList<IWebElement> resultsList { get; set; }

    }
}
