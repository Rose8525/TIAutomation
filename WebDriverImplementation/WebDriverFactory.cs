using OpenQA.Selenium;

namespace TIAutomation.WebDriverImplementation;
public class WebDriverFactory
{
    public static IWebDriver GetDriver(String browser)
    {
        switch (browser)
        {
            case "chrome":
                ChromeDriverCreator chromeDriver = new ChromeDriverCreator();
                return chromeDriver.CreateWebDriver();
            case "firefox":
                FirefoxDriverCreator firefoxDriver = new FirefoxDriverCreator();
                return firefoxDriver.CreateWebDriver();
            default:
                throw new Exception("Browser" + browser + "Not supported");

        }

    }
}

