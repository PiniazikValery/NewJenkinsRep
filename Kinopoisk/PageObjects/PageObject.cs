using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.PageObjects
{
    public class PageObject
    {
        protected IWebDriver driver { get; set; }

        public PageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

    }
}
