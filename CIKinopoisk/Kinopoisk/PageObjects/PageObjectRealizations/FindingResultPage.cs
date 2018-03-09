using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.PageObjects.PageObjectRealizations
{
    public class FindingResultPage : PageObject
    {
        public FindingResultPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='headerFilm']/h1")]
        private IWebElement HeaderFilm { get; set; }

        public string GetResultOfFoundFilm()
        {
            return HeaderFilm.Text;
        }
    }
}
