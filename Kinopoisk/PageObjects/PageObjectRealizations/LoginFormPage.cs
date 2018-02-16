using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.PageObjects.PageObjectRealizations
{
    public class LoginFormPage : PageObject
    {
        public LoginFormPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("kp2-authapi-iframe")));
        }

        [FindsBy(How = How.XPath, Using = "//*[@class='auth__inner']//*/input[@name='login']")]
        private IWebElement EmailInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='auth__inner']//*/input[@name='password']")]
        private IWebElement PasswordInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/div[@class='auth__signin-mode']/button")]
        public IWebElement LoginSubmit { get; set; }

        public void SendKeysToPasswordInput(string keys)
        {
            PasswordInput.SendKeys(keys);
        }

        public void SendKeysToEmailInput(string keys)
        {
            EmailInput.SendKeys(keys);
        }
        public void ClickSubmit()
        {
            LoginSubmit.Click();
        }

    }
}
