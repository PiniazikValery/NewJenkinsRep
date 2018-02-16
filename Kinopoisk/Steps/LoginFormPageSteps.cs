using Kinopoisk.PageObjects.PageObjectRealizations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Steps
{
    public static class LoginFormPageSteps
    {
        static Func<IWebElement, bool> LoginSubmitWaiter = new Func<IWebElement, bool>((IWebElement ele) =>
        {
            return ele.Enabled;
        });
        static Func<IWebElement, bool> IFrameLoadWait = new Func<IWebElement, bool>((IWebElement ele) =>
        {
            return ele.Displayed;
        });
        public static void FillLoginForm(this LoginFormPage page)
        {
            DefaultWait<IWebElement> wait = new DefaultWait<IWebElement>(page.LoginSubmit);
            wait.Timeout = TimeSpan.FromMinutes(2);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.Until(IFrameLoadWait);
            page.SendKeysToEmailInput("arclonerholdon@gmail.com");
            page.SendKeysToPasswordInput("Dfkthfgbyzpbr1");
            wait.Until(LoginSubmitWaiter);
        }
        public static void ClickSubmit(this LoginFormPage page)
        {
            page.ClickSubmit();
        }
    }
}
