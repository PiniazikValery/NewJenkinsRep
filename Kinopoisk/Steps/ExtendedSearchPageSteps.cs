using Kinopoisk.PageObjects.PageObjectRealizations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Steps
{
    public static class ExtendedSearchPageSteps
    {
        public static void FillWnatedFilmParam(this ExtendedSearchPage page)
        {
            page.SendKeyToFilmNameField("Pirats");
            page.SelectFirstYearInterval("1990");
            page.SelectGenre("аниме");
            page.SelectWhatFilmSearch("сериал");
        }
        public static void FillSearchByCreators(this ExtendedSearchPage page)
        {
            page.SelectFirstCreator("Актер");
            page.SelectSecondCreator("Режиссер");
            page.SendKeysToFirstCreatorField("Jhony Depp");
            page.SendKeysToSecondCreatorField("Lucas");
        }
    }
}
