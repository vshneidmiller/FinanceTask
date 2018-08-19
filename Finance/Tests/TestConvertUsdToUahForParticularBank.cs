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
    class TestConvertUsdToUahForParticularBank

    {
        [Test]
        [Description("Verifies if the converter displays the correct amount of UAH for conversion from USD for particular bank")]

        public void ConvertUsdToUahForParticularBank()
        {
            //Bank can be changed in the Config class

            IWebDriver driver = new ChromeDriver();
            HomePage home = new HomePage(driver);
            Converter converter = new Converter(driver);
            BankRate bankRate = new BankRate(driver);

            home.GoTo();
            driver.Manage().Window.Maximize();

            converter.SelectBank(Config.bankName);
            int amount = 1000;
            converter.amount.SendKeys(amount.ToString());

            double actualAmountUah = Math.Round(converter.GetAmountUah(), 2);
            double expectedAmountUah = Math.Round(amount * bankRate.GetBankBuy(Config.bankName), 2);

            Assert.AreEqual(actualAmountUah, expectedAmountUah);

            driver.Quit();

        }
    }
}
