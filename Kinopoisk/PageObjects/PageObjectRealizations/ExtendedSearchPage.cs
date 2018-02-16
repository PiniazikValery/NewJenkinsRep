using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.PageObjects.PageObjectRealizations
{
    public class ExtendedSearchPage : PageObject
    {
        public ExtendedSearchPage(IWebDriver driver) : base(driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //Search Film Form
        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[find]' and @id='find_film']")]
        private IWebElement FilmName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[year]' and @id='year']")]
        private IWebElement FilmYear { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[actor]']")]
        private IWebElement Actor { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[cast]']")]
        private IWebElement Creators { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='from_year']")]
        private IWebElement FirstYearInterval { get; set; }

        private SelectElement FirstYearIntervalDropDown
        {
            get { return new SelectElement(FirstYearInterval); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='to_year']")]
        private IWebElement LastYearInterval { get; set; }

        private SelectElement LastYearIntervalDropDown
        {
            get { return new SelectElement(LastYearInterval); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='country']")]
        private IWebElement Country { get; set; }

        private SelectElement CountryDropDown
        {
            get { return new SelectElement(Country); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='company']")]
        private IWebElement Distributor { get; set; }

        private SelectElement DistributorDropDown
        {
            get { return new SelectElement(Distributor); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@name='m_act[mpaa]']")]
        private IWebElement MPAA { get; set; }

        private SelectElement MPAADropDown
        {
            get { return new SelectElement(MPAA); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='m_act[genre]']")]
        private IWebElement Genre { get; set; }

        private SelectElement GenreDropDown
        {
            get { return new SelectElement(Genre); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='prem_month']")]
        private IWebElement PremMounth { get; set; }

        private SelectElement PremMounthDropDown
        {
            get { return new SelectElement(PremMounth); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='prem_year']")]
        private IWebElement PremYear { get; set; }

        private SelectElement PremYearDropDown
        {
            get { return new SelectElement(PremYear); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='prem_type']")]
        private IWebElement PremType { get; set; }

        private SelectElement PremTypeDropDown
        {
            get { return new SelectElement(PremType); }
        }

        [FindsBy(How = How.Name, Using = "m_act[box_vector]")]
        private IWebElement SborsSelect { get; set; }

        private SelectElement SborsSelectDropDown
        {
            get { return new SelectElement(SborsSelect); }
        }

        [FindsBy(How = How.Name, Using = "m_act[box]")]
        private IWebElement SborsValue { get; set; }

        [FindsBy(How = How.Name, Using = "m_act[box_type]")]
        private IWebElement SborsType { get; set; }

        private SelectElement SborsTypeDropDown
        {
            get { return new SelectElement(SborsType); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='formSearchMain']//*[@name='m_act[content_find]']")]
        private IWebElement WhatFilmSearch { get; set; }

        private SelectElement WhatFilmSearchDropDown
        {
            get { return new SelectElement(WhatFilmSearch); }
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='formSearchMain']//*[@class='el_18 submit nice_button']")]
        private IWebElement SearchFilmButton { get; set; }

        public void SendKeyToFilmNameField(string keys)
        {
            FilmName.SendKeys(keys);
        }

        public void SendKeysToFilmYearField(string keys)
        {
            FilmYear.SendKeys(keys);
        }
        public void SendKeysToActorField(string keys)
        {
            Actor.SendKeys(keys);
        }
        public void SendKeysToCreatorsField(string keys)
        {
            Creators.SendKeys(keys);
        }
        public void SendKeysToSborsValueField(string keys)
        {
            SborsValue.SendKeys(keys);
        }
        public void SelectFirstYearInterval(string text)
        {
            FirstYearIntervalDropDown.SelectByText(text);
        }
        public void SelectLastYearInterval(string text)
        {
            LastYearIntervalDropDown.SelectByText(text);
        }
        public void SelectCountry(string text)
        {
            CountryDropDown.SelectByText(text);
        }
        public void SelectDistributor(string text)
        {
            DistributorDropDown.SelectByText(text);
        }
        public void SelectMPAA(string text)
        {
            MPAADropDown.SelectByText(text);
        }
        public void SelectGenre(string text)
        {
            GenreDropDown.SelectByText(text);
        }
        public void SelectPremMounth(string text)
        {
            PremMounthDropDown.SelectByText(text);
        }
        public void SelectPremYear(string text)
        {
            PremYearDropDown.SelectByText(text);
        }
        public void SelectPremType(string text)
        {
            PremTypeDropDown.SelectByText(text);
        }
        public void SelectSborsSelect(string text)
        {
            SborsSelectDropDown.SelectByText(text);
        }
        public void SelectSborsType(string text)
        {
            SborsTypeDropDown.SelectByText(text);
        }
        public void SelectWhatFilmSearch(string text)
        {
            WhatFilmSearchDropDown.SelectByText(text);
        }
        public void ClickSearchFilmButton()
        {
            SearchFilmButton.Click();
        }
        //Search by creators form
        [FindsBy(How = How.Id, Using = "btn_search_6")]
        private IWebElement SearchByCreatorsButton { get; set; }

        [FindsBy(How = How.Id, Using = "cr_search_field_1_select")]
        private IWebElement FirstCreator { get; set; }
        private SelectElement FirstCreatorDropDown
        {
            get { return new SelectElement(FirstCreator); }
        }

        [FindsBy(How = How.Id, Using = "cr_search_field_2_select")]
        private IWebElement SecondCreator { get; set; }
        private SelectElement SecondCreatorDropDown
        {
            get { return new SelectElement(SecondCreator); }
        }

        [FindsBy(How = How.Id, Using = "cr_search_field_1")]
        private IWebElement FirstCreatorField { get; set; }

        [FindsBy(How = How.Id, Using = "cr_search_field_2")]
        private IWebElement SecondCreatorField { get; set; }

        public void SelectFirstCreator(string text)
        {
            FirstCreatorDropDown.SelectByText(text);
        }
        public void SelectSecondCreator(string text)
        {
            SecondCreatorDropDown.SelectByText(text);
        }
        public void SendKeysToFirstCreatorField(string keys)
        {
            FirstCreatorField.SendKeys(keys);
        }
        public void SendKeysToSecondCreatorField(string keys)
        {
            SecondCreatorField.SendKeys(keys);
        }
    }
}
