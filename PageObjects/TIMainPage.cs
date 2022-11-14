using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TIAutomation.PageObjects
{
    public class TIMainPage : BasePage
    {
        //Sections
        private readonly By _sectionIndustry = By.XPath("//*[@data-anchor=\"industry\"]");
        private readonly By _sectionServices = By.XPath("//*[@data-anchor=\"services\"]");
        private readonly By _sectionClients = By.XPath("//*[@data-anchor=\"clients\"]");
        private readonly By _sectionLocations = By.XPath("//*[@data-anchor=\"locations\"]");
        private readonly By _sectionEducation = By.XPath("//*[@data-anchor=\"education\"]");
        private readonly By _sectionCareer = By.XPath("//*[@data-anchor=\"career\"]");
        private readonly By _sectionContactUs = By.XPath("//*[@data-anchor=\"contact-us\"]");

        //Section "Industry" 
        private readonly By _subSectionsH3Logistics = By.XPath("//h3[contains(text(),'Logistics')]");
        private readonly By _subSectionsPLogistics = By.XPath("//h3[contains(text(),'Logistics')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3Oil = By.XPath("//h3[contains(text(),'Oil')]");
        private readonly By _subSectionsPOil = By.XPath("//h3[contains(text(),'Oil')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3Telecom = By.XPath("//h3[contains(text(),'Telecom')]");
        private readonly By _subSectionsPTelecom = By.XPath("//h3[contains(text(),'Telecom')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3Technology = By.XPath("//h3[contains(text(),'Technology')]");
        private readonly By _subSectionsPTechnology = By.XPath("//h3[contains(text(),'Technology')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3Financial = By.XPath("//h3[contains(text(),'Financial')]");
        private readonly By _subSectionsPFinancial = By.XPath("//h3[contains(text(),'Financial')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3HealthCare = By.XPath("//h3[contains(text(),'Healthcare ')]");
        private readonly By _subSectionsPHealthCare = By.XPath("//h3[contains(text(),'Healthcare ')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3Travel = By.XPath("//h3[contains(text(),'Travel')]");
        private readonly By _subSectionsPTravel = By.XPath("//h3[contains(text(),'Travel')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3Retail = By.XPath("//h3[contains(text(),'Retail')]");
        private readonly By _subSectionsPRetail = By.XPath("//h3[contains(text(),'Retail')]//parent::div//p[@class='industrial-description']");
        private readonly By _subSectionsH3Digital = By.XPath("//h3[contains(text(),'Digital')]");
        private readonly By _subSectionsPDigital = By.XPath("//h3[contains(text(),'Digital')]//parent::div//p[@class='industrial-description']");

        //Section "Services" 
        private readonly By _subSectionsPDevelopment1 = By.XPath("//p[contains(text(),'Software Development Outsourcing')]");
        private readonly By _subSectionsPDevelopment2 = By.XPath("//p[contains(text(),'Software Development Outsourcing')]/following-sibling::p");
        private readonly By _subSectionsPAutomation1 = By.XPath("//p[contains(text(),'Automation')]");
        private readonly By _subSectionsPAutomation2 = By.XPath("//p[contains(text(),'Automation')]/following-sibling::p");
        private readonly By _subSectionsPQA1 = By.XPath("//p[contains(text(),'Software QA')]");
        private readonly By _subSectionsPQA2 = By.XPath("//p[contains(text(),'Software QA')]/following-sibling::p");
        private readonly By _subSectionsPMicrosoft1 = By.XPath("//p[contains(text(),'Microsoft')]");
        private readonly By _subSectionsPMicrosoft2 = By.XPath("//p[contains(text(),'Microsoft')]/following-sibling::p");
        private readonly By _subSectionsPConsulting1 = By.XPath("//p[contains(text(),'Professional IT')]");
        private readonly By _subSectionsPConsulting2 = By.XPath("//p[contains(text(),'Professional IT')]/following-sibling::p");
        private readonly By _subSectionsPAnalytics1 = By.XPath("//p[contains(text(),'Data')]");
        private readonly By _subSectionsPAnalytics2 = By.XPath("//p[contains(text(),'Data')]/following-sibling::p");
        private readonly By _subSectionsPManaged1 = By.XPath("//p[contains(text(),'Managed IT')]");
        private readonly By _subSectionsPManaged2 = By.XPath("//p[contains(text(),'Managed IT')]/following-sibling::p");

        //Section "They Trust Us" 
        private readonly By _logos = By.XPath("//div[contains(@id,'logo-partners')]");

        //Section "Locations" 
        private readonly By _buttonLearnMore = By.XPath("//div[contains(@class, 'slick-current') and contains(@class, 'location-item')]//a");
        private readonly By _imgNext = By.XPath("//img[contains(@class, 'slick-arrow') and contains(@class, 'next ')]");

        //Section "Careers" 
        private readonly By _buttonSeeAllOffers = By.XPath("//a[contains(text(),'see all offers')]");

        //Section "Top Gun Lab" 
        private readonly By _buttonSeeMore = By.XPath("//a[contains(text(),'see more')]");

        //Section Contact Sales
        private readonly By _iFrameContactSales = By.XPath("//iframe[@title='Candidates Form']");
        private readonly By _inputFirstName = By.XPath("//input[@data-id='firstName']");
        private readonly By _inputLastName = By.XPath("//input[@data-id='lastName']");
        private readonly By _inputCompany = By.XPath("//input[@data-id='company']");
        private readonly By _inputEmail = By.XPath("//input[@data-id='email']");
        private readonly By _inputPhone = By.XPath("//input[@data-id='phone']");
        private readonly By _inputMessage = By.XPath("//input[@data-id='message']");
        private readonly By _checkConfirm = By.XPath("(//span[@class=\"checkmark\"])[1]");
        private readonly By _checkSuscribe = By.XPath("(//span[@class=\"checkmark\"])[2]");
        private readonly By _text = By.XPath("(//div[@class='thanks-text'])[1]");
        private By _buttonSubmit = By.XPath("//input[@class='submit-button']");

        public TIMainPage(IWebDriver driver) : base(driver)
        {
        }

        public string AccessWebSite()
        {
            return _driver.Title;
        }

        public void NavigateAllSections()
        {
            GoToSection(_sectionIndustry);
            GoToSection(_sectionServices);
            GoToSection(_sectionClients);
            GoToSection(_sectionLocations);
            GoToSection(_sectionEducation);
            GoToSection(_sectionCareer);
            GoToSection(_sectionContactUs);
        }

        public void GoToSection(By byElement)
        {
            ScrollToElement(_driver.FindElement(byElement));
            Thread.Sleep(TimeSpan.FromSeconds(1));
        }

        public string FillContactForm()
        {

            GoToSection(_sectionContactUs);
            Thread.Sleep(TimeSpan.FromSeconds(3));
            _driver.SwitchTo().Frame(_driver.FindElement(_iFrameContactSales));

            CompleteField(_driver.FindElement(_inputFirstName), "Rosa");
            CompleteField(_driver.FindElement(_inputLastName), "Cera");
            CompleteField(_driver.FindElement(_inputCompany), "TEAM");
            CompleteField(_driver.FindElement(_inputEmail), "rosamariaceraosorio@gmail.com");
            CompleteField(_driver.FindElement(_inputPhone), "+59893810783");
            CompleteField(_driver.FindElement(_inputMessage), "This is an automation test.");
            ClickElement(_driver.FindElement(_checkConfirm));
            ClickElement(_driver.FindElement(_checkSuscribe));
            ClickElement(_driver.FindElement(_buttonSubmit));
            WebDriverExtensions.WebDriverExtensions.IsElementDisplayed(_driver, _text, 10);
            var text = GetElementText(_driver.FindElement(_text));
            _driver.SwitchTo().DefaultContent();
            return text;
        }

        public string AccessToIndustryLogisticSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Logistics, _subSectionsPLogistics);
        }

        public string AccessToIndustryOilSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Oil, _subSectionsPOil);
        }

        public string AccessToIndustryTelecomSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Telecom, _subSectionsPTelecom);
        }

        public string AccessToIndustryTechnologySubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Technology, _subSectionsPTechnology);
        }

        public string AccessToIndustryFinancialSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Financial, _subSectionsPFinancial);
        }

        public string AccessToIndustryHealthCareSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3HealthCare, _subSectionsPHealthCare);
        }

        public string AccessToIndustryTravelSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Travel, _subSectionsPTravel);
        }

        public string AccessToIndustryRetailSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Retail, _subSectionsPRetail);
        }

        public string AccessToIndustryDigitalSubsection()
        {
            return GoToClickedLink(_sectionIndustry, _subSectionsH3Digital, _subSectionsPDigital);
        }

        public void AccessToTheyTrustUsSubsection()
        {
            GoToSection(_sectionClients);
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var list = _driver.FindElements(_logos);
            foreach (var l in list)
            {
                wait.Until(driver => l.Displayed);
                MouseOverElement(l);
            }
        }

        public string AccessToServicesSubsectionDev()
        {
            return GoToClickedLink(_sectionServices, _subSectionsPDevelopment1, _subSectionsPDevelopment2);
        }

        public string AccessToServicesSubsectionAutomation()
        {
            return GoToClickedLink(_sectionServices, _subSectionsPAutomation1, _subSectionsPAutomation2);
        }

        public string AccessToServicesSubsectionQA()
        {
            return GoToClickedLink(_sectionServices, _subSectionsPQA1, _subSectionsPQA2);
        }

        public string AccessToServicesSubsectionMicrosoft()
        {
            return GoToClickedLink(_sectionServices, _subSectionsPMicrosoft1, _subSectionsPMicrosoft2);
        }

        public string AccessToServicesSubsectionConsulting()
        {
            return GoToClickedLink(_sectionServices, _subSectionsPConsulting1, _subSectionsPConsulting2);
        }

        public string AccessToServicesSubsectionAnalytics()
        {
            return GoToClickedLink(_sectionServices, _subSectionsPAnalytics1, _subSectionsPAnalytics2);
        }

        public string AccessToServicesSubsectionManaged()
        {
            return GoToClickedLink(_sectionServices, _subSectionsPManaged1, _subSectionsPManaged2);
        }

        public string AccessToServicesSubsectionTopGun()
        {
            return GoToClickedNewTabLink(_sectionEducation, _buttonSeeMore);
        }

        public string AccessToCareersSubsection()
        {
            return GoToClickedNewTabLink(_sectionCareer, _buttonSeeAllOffers);
        }

        public string AccessToLocationsSubsection(int click)
        {
            GoToSection(_sectionLocations);
            for (int i = 0; i < click; i++)
            {
                var nextBtn = _driver.FindElement(_imgNext);
                WebDriverExtensions.WebDriverExtensions.IsElementEnable(_driver, _imgNext, 10);
                ClickElement(nextBtn);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
            var digitalP1 = _driver.FindElement(_buttonLearnMore);
            WebDriverExtensions.WebDriverExtensions.IsElementEnable(_driver, _buttonLearnMore, 10);
            MouseOverElement(digitalP1);
            ClickElement(digitalP1);
            string url = _driver.Url;
            _driver.Navigate().Back();
            return url;
        }

        private string GoToClickedLink(By section, By xpathElementToMouseOver, By xpathElementToClick)
        {
            GoToSection(section);
            var elementToMouseOver = _driver.FindElement(xpathElementToMouseOver);
            var elementToClick = _driver.FindElement(xpathElementToClick);
            WebDriverExtensions.WebDriverExtensions.IsElementEnable(_driver, xpathElementToMouseOver, 10);
            MouseOverElement(elementToMouseOver);
            ClickElement(elementToClick);
            var title = _driver.Title;
            _driver.Navigate().Back();
            return title;
        }

        private string GoToClickedNewTabLink(By section, By xpathElement)
        {
            GoToSection(section);
            string currentHandle = _driver.CurrentWindowHandle;
            var webElement = _driver.FindElement(xpathElement);
            WebDriverExtensions.WebDriverExtensions.IsElementEnable(_driver, xpathElement, 10);
            MouseOverElement(webElement);
            ClickElement(webElement);
            string title = "";
            IList<string> s1 = _driver.WindowHandles;

            for (int i = 0; i < s1.Count - 1; i++)
            {
                string childWindow = s1[i + 1];

                if (currentHandle != childWindow)
                {
                    _driver.SwitchTo().Window(childWindow);
                    title = _driver.Title;
                }
            }
            return title;
        }


    }
}
