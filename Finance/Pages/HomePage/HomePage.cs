using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Pages
{
    class HomePage
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "body > div.body_container > div.page.page-sidebar.page-homepage > div > div.page_content > div.widget.widget-currency_summary > div.widget-currency_bank > div > table > tbody > tr:nth-child(1) > td:nth-child(2) > span > span:nth-child(1)")]
        public IWebElement usdBuy { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.body_container > div.page.page-sidebar.page-homepage > div > div.page_content > div.widget.widget-currency_summary > div.widget-currency_bank > div > table > tbody > tr:nth-child(1) > td:nth-child(3) > span > span:nth-child(1)")]
        public IWebElement usdSell { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.body_container > div.page.page-sidebar.page-homepage > div > div.page_content > div.widget.widget-currency_summary > div.widget-currency_bank > div > table > tbody > tr:nth-child(2) > td:nth-child(2) > span > span:nth-child(1)")]
        public IWebElement eurBuy { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.body_container > div.page.page-sidebar.page-homepage > div > div.page_content > div.widget.widget-currency_summary > div.widget-currency_bank > div > table > tbody > tr:nth-child(2) > td:nth-child(3) > span > span:nth-child(1)")]
        public IWebElement eurSell { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.body_container > div.page.page-sidebar.page-homepage > div > div.page_content > div.widget.widget-currency_summary > div.widget-currency_bank > div > table > tbody > tr:nth-child(3) > td:nth-child(2) > span > span:nth-child(1)")]
        public IWebElement rubBuy { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body > div.body_container > div.page.page-sidebar.page-homepage > div > div.page_content > div.widget.widget-currency_summary > div.widget-currency_bank > div > table > tbody > tr:nth-child(3) > td:nth-child(3) > span > span:nth-child(1)")]
        public IWebElement rubSell { get; set; }

        [FindsBy(How = How.Id, Using = "amount")]
        public IWebElement currency_amount { get; set; }




        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void GoTo()
        {
            driver.Navigate().GoToUrl("https://finance.i.ua/");
        }

        public double GetDiffBetweenSellAndBuy(string sell, string buy)
        {
            return Convert.ToDouble(sell) - Convert.ToDouble(buy);
        }

        public double GetUsdBuy()
        {
            return Convert.ToDouble(usdBuy.Text);
        }

    }
}
