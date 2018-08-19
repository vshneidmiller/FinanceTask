using Finance.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Tests
{
    class TestPageTitles
    {

        [Test]
        [Description("Verifies if the page's titles are the same as in the Config Class")]

        public void CheckPageTitles()
        {
            IWebDriver driver = new ChromeDriver();
            HomePage home = new HomePage(driver);
            Menu menu = new Menu(driver);

            home.GoTo();
            driver.Manage().Window.Maximize();

            menu.Market.Click();
            string actualMarketTitle = driver.Title;

            menu.Nbu.Click();
            string actualNbuTitle = driver.Title;

            menu.Fuel.Click();
            string actualFuelTitle = driver.Title;

            menu.Converter.Click();
            string actualConverterTitle = driver.Title;

            menu.Main.Click();
            string actualMainTitle = driver.Title;

            Assert.AreEqual(actualMainTitle, Config.PageElements.Titles.mainTitle);
            Assert.AreEqual(actualMarketTitle, Config.PageElements.Titles.marketTitle);
            Assert.AreEqual(actualNbuTitle, Config.PageElements.Titles.nbuTitle);
            Assert.AreEqual(actualConverterTitle, Config.PageElements.Titles.converterTitle);
            Assert.AreEqual(actualMainTitle, Config.PageElements.Titles.mainTitle);

            driver.Quit();

        }

    }
}
