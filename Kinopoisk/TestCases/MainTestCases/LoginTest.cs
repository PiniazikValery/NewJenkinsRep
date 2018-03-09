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
    class LoginTest : BaseTestCase
    {
        [SetUp]
        public void BeforeTest()
        {
            BrowserFactory.InitBrowser(WebBrowsers.Chrome);
            user = new Tester(BrowserFactory.GetDriver);
            BrowserFactory.LoadApplication("https://www.kinopoisk.ru/");
        }
        [Test]
        public void Login()
        {
            user.AtPage<KinopoiskStartPage>().ClickLogin();
            user.AtPage<LoginFormPage>().FillLoginForm();
            user.AtPage<LoginFormPage>().ClickSubmit();
        }
        [TearDown]
        public void AfterTest()
        {
            user.AtPage<KinopoiskStartPage>().WaitNClickLogoutButton();            
        }
    }
}
