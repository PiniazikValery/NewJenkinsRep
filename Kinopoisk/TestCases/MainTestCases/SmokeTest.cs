using Kinopoisk.BrowserFactory;
using Kinopoisk.PageObjects.PageObjectRealizations;
using Kinopoisk.Steps;
using Kinopoisk.Users;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.TestCases.MainTestCases
{
    [TestFixture]
    [Parallelizable]
    class SmokeTest : BaseTestCase
    {
        [SetUp]
        public void BeforeTest()
        {
            BrowserFactory.InitBrowser(WebBrowsers.Chrome);
            user = new Tester(BrowserFactory.GetDriver);
            BrowserFactory.LoadApplication("https://www.kinopoisk.ru/");
        }
        [Test]
        public void SmokeTestSite()
        {
            user.AtPage<KinopoiskStartPage>().SearchFilm();
            user.AtPage<SearchedPage>().ClickOnTargetLink();
        }
        [TearDown]
        public void AfterTest()
        {
            BrowserFactory.CloseDriver();
        }
    }
}
