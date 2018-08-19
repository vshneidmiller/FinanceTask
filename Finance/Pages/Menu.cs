using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance.Pages
{
    class Menu
    {
        private IWebDriver driver;

        [FindsBy(How = How.CssSelector, Using = "#section_nav > div > div.sn_menu_set.sn_menu_set-main > ul > li:nth-child(1)")]
        public IWebElement Main { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#section_nav > div > div.sn_menu_set.sn_menu_set-main > ul > li:nth-child(2)")]
        public IWebElement Market { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#section_nav > div > div.sn_menu_set.sn_menu_set-main > ul > li:nth-child(3)")]
        public IWebElement Nbu { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#section_nav > div > div.sn_menu_set.sn_menu_set-main > ul > li:nth-child(4)")]
        public IWebElement Fuel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#section_nav > div > div.sn_menu_set.sn_menu_set-main > ul > li:nth-child(5)")]
        public IWebElement Converter { get; set; }


        public Menu(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public List<IWebElement> GetMenuItems()
        {
            List<IWebElement> MenuItems = new List<IWebElement>();

            MenuItems.Add(Main);
            MenuItems.Add(Market);
            MenuItems.Add(Nbu);
            MenuItems.Add(Fuel);
            MenuItems.Add(Converter);

            return MenuItems;
        }
    }
}
