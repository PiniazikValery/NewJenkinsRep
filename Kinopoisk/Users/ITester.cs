using Kinopoisk.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Users
{
    public interface ITester
    {
        TPageObject AtPage<TPageObject>() where TPageObject : PageObject;
    }
}
