using Kinopoisk.BrowserFactory;
using Kinopoisk.Users;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.TestCases
{
    [TestFixture]
    public class BaseTestCase
    {
        protected ITester user;
        protected IBrowserFactory BrowserFactory;
        protected string startPage { private get; set; }
        protected WebBrowsers browser { private get; set; }


        [OneTimeSetUp]
        public void BeforeAllTests()
        {
            BrowserFactory = new WebDriverFactory(browser, startPage);
        }

        [OneTimeTearDown]
        public void AfterAllTests()
        {
            BrowserFactory.CloseDriver();
        }
    }
}
