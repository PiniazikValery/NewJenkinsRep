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
    class TestExtendedSearch : BaseTestCase
    {
        [SetUp]
        public void BeforeTest()
        {
            BrowserFactory.InitBrowser(WebBrowsers.Chrome);
            user = new Tester(BrowserFactory.GetDriver);
            BrowserFactory.LoadApplication("https://www.kinopoisk.ru/s");
        }
        [Test]
        public void TestExtendedFilmFound()
        {
            user.AtPage<ExtendedSearchPage>().FillWnatedFilmParam();
            user.AtPage<ExtendedSearchPage>().ClickSearchFilmButton();
        }
        [TearDown]
        public void AfterTest()
        {
            BrowserFactory.LoadApplication("https://www.kinopoisk.ru/s");            
        }
    }
}
