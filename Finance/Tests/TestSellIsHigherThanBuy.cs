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
    class TestSellIsHigherThanBuy
    {
        [Test]
        [Description("Verify if sell price is higher than buy price")]

        public void CheckIfSellIsHigherThanBuy()
        {
            IWebDriver driver = new ChromeDriver();
            HomePage home = new HomePage(driver);

            home.GoTo();
            driver.Manage().Window.Maximize();
            
            Console.WriteLine("USD difference  = " + home.GetDiffBetweenSellAndBuy(home.usdSell.Text, home.usdBuy.Text));
            Console.WriteLine("EUR difference  = " + home.GetDiffBetweenSellAndBuy(home.eurSell.Text, home.eurBuy.Text));
            Console.WriteLine("RUB difference  = " + home.GetDiffBetweenSellAndBuy(home.rubSell.Text, home.rubBuy.Text));

            Assert.Greater(Convert.ToDouble(home.usdSell.Text), Convert.ToDouble(home.usdBuy.Text));
            Assert.Greater(Convert.ToDouble(home.eurSell.Text), Convert.ToDouble(home.eurBuy.Text));
            Assert.Greater(Convert.ToDouble(home.rubSell.Text), Convert.ToDouble(home.rubBuy.Text));

            driver.Quit();
        }

    }
}
