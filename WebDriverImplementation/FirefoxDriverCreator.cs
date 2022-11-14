using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TIAutomation.WebDriverImplementation
{
    public class FirefoxDriverCreator : WebDriverCreator
    {
        public override IWebDriver CreateWebDriver()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            firefoxOptions.SetPreference("dom.webnotifications.enabled", false);
            firefoxOptions.AcceptInsecureCertificates = true;
            return new FirefoxDriver(firefoxOptions);
        }
    }
}