using Kinopoisk.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Users
{
    public class Tester : ITester
    {
        IWebDriver driver;

        IList<PageObject> _pagesContainer;

        public Tester(IWebDriver driver)
        {
            this.driver = driver;
            _pagesContainer = new List<PageObject>();
        }

        public TPageObject AtPage<TPageObject>() where TPageObject : PageObject
        {
            var result = turnToContainer<TPageObject>();
            CheckType<TPageObject>();
            return result;
        }

        private TPageObject turnToContainer<TPageObject>() where TPageObject : PageObject
        {
            var result = findInContainer(typeof(TPageObject));
            if (result != null)
            {
                return result as TPageObject;
            }
            else
            {
                result = (TPageObject)Activator.CreateInstance(typeof(TPageObject), driver);
                _pagesContainer.Add(result);
                return result as TPageObject;
            }
        }

        private bool IsPageObject<InputObject>()
        {
            bool result = false;
            Type pageObjectType = typeof(PageObject);
            IEnumerable<Type> ListOfHeirs = Assembly.GetAssembly(pageObjectType).GetTypes().Where(type => type.IsSubclassOf(pageObjectType));
            foreach (Type heir in ListOfHeirs)
            {
                if (typeof(InputObject) == heir)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private void CheckType<Type>()
        {
            if (!IsPageObject<Type>())
            {
                throw new TypeAccessException("The class is not the heir of the PageObject");
            }
        }

        private PageObject findInContainer(Type type)
        {
            PageObject result = null;
            foreach (var page in _pagesContainer)
            {
                if (page.GetType() == type)
                {
                    result = page;
                    break;
                }
            }
            return result;
        }

    }
}
