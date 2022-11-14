using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TIAutomation.WebDriverImplementation
{
    public class ChromeDriverCreator : WebDriverCreator
    {
        public override IWebDriver CreateWebDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--disable-notifications");
            return new ChromeDriver(chromeOptions);
        }
    }
}