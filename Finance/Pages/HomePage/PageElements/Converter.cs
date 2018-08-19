using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Pages
{
    class Converter
    {

        private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "currency_amount")]
        public IWebElement amount { get; set; }

        [FindsBy(How = How.Id, Using = "currency_rate")]
        public IWebElement rate { get; set; }

        [FindsBy(How = How.Id, Using = "currency_exchange")]
        public IWebElement exchange { get; set; }

        [FindsBy(How = How.Id, Using = "converter_bank")]
        public IWebElement bank { get; set; }


        public Converter(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public double GetAmountUah()
        {
            return Convert.ToDouble(this.exchange.GetAttribute("value").Replace(" ", ""));
        }

        public void SelectBank(string bank)
        {
            
            switch (bank)
            {
                case "Аркада":
                    driver.FindElement(By.CssSelector("#converter_bank > option:nth-child(" + 1 + ")")).Click();
                    break;

                case "Ощадбанк":
                    driver.FindElement(By.CssSelector("#converter_bank > option:nth-child(" + 2 + ")")).Click();
                    break;

                case "ПриватБанк":
                    driver.FindElement(By.CssSelector("#converter_bank > option:nth-child(" + 15 + ")")).Click();
                    break;

                default:
                    break;
            }

            
            IWebElement GetBank(int i)
            {
               return driver.FindElement(By.CssSelector("#converter_bank > option:nth-child(" + i +")"));
            }

        }
    }
}
