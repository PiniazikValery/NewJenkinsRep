using Kinopoisk.PageObjects.PageObjectRealizations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Steps
{
    public static class StartPageSteps
    {
        public static void SearchFilm(this KinopoiskStartPage page)
        {
            page.SendKeysToSearchLine();
            page.ClickSearchButton();
            var resultToAssert = new SearchedPage(page.GetDriver());
            Assert.IsNotNull(resultToAssert.TargetLink);
        }

        public static void WaitNClickLogoutButton(this KinopoiskStartPage page)
        {
            WebDriverWait wait = new WebDriverWait(page.GetDriver(), TimeSpan.FromSeconds(5));
            Func<IWebDriver, bool> waitForElement = new Func<IWebDriver, bool>((IWebDriver Web) =>
            {
                return page.GetLogOutButton().Displayed;
            });
            wait.Until(waitForElement);
            page.ClickLogOutButton();
        }
    }
}
