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
    class TestConvertUsdToUah
    {
        [Test]
        [Description("Verifies if the converter displays the correct amount of UAH for conversion from USD")]

        public void ConvertUsdToUah()
        {
            IWebDriver driver = new ChromeDriver();
            HomePage home = new HomePage(driver);
            Converter converter = new Converter(driver);

            home.GoTo();
            driver.Manage().Window.Maximize();

            int amountToExchange = 1000;
            converter.amount.SendKeys(amountToExchange.ToString());

            double actualAmountUah = Math.Round(converter.GetAmountUah(), 2);
            double expectedAmountUah = Math.Round(amountToExchange * home.GetUsdBuy(), 2);

            Assert.AreEqual(actualAmountUah, expectedAmountUah);

            driver.Quit();

        }
    }
}
