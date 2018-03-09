using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.PageObjects.PageObjectRealizations
{
    public class SearchedPage : PageObject
    {
        public SearchedPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Пираты Карибского моря: Проклятие Черной жемчужины")]
        public IWebElement TargetLink { get; private set; }

        public void ClickOnTargetLink()
        {
            TargetLink.Click();
            var resultToAssert = new FindingResultPage(driver);
            Assert.IsTrue("Пираты Карибского моря: Проклятие Черной жемчужины" == resultToAssert.GetResultOfFoundFilm());
        }
    }
}
