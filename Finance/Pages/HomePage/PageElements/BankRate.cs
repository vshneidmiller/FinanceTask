using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Pages
{
    class BankRate
    {

        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "#latest_currency_container > tbody.bank_rates_usd > tr:nth-child(20) > td.buy_rate > span > span")]
        public IWebElement PrivatBankBuy { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#latest_currency_container > tbody.bank_rates_usd > tr:nth-child(20) > td.sell_rate > span > span")]
        public IWebElement PrivatBankSell { get; set; }
        

        public BankRate(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public double GetBankBuy(string bank)
        {
            string buy;

            switch (bank)
            {
                
                case "Аркада":
                    buy = driver.FindElement(By.CssSelector("#latest_currency_container > tbody.bank_rates_usd > tr:nth-child(7) > td.buy_rate > span > span")).Text;
                    return Convert.ToDouble(buy);

                case "Ощадбанк":
                    buy = driver.FindElement(By.CssSelector("#latest_currency_container > tbody.bank_rates_usd > tr:nth-child(18) > td.buy_rate > span > span")).Text;
                    return Convert.ToDouble(buy);

                case "ПриватБанк":
                    buy = driver.FindElement(By.CssSelector("#latest_currency_container > tbody.bank_rates_usd > tr:nth-child(20) > td.buy_rate > span > span")).Text;
                    return Convert.ToDouble(buy);

                default:
                    return 0;

            }
        }



    }
}


