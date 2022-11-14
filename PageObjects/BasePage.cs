using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;

namespace TIAutomation.PageObjects
{
    public class BasePage
    {
        protected readonly IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
        public void CompleteField(IWebElement element, string value)
        {
            element.Click();
            element.Clear();
            element.SendKeys(value);
        }

        public void ClickElement(IWebElement element)
        {
            element.Click();
        }

        public string GetElementText(IWebElement element)
        {
            return element.Text;
        }

        public void ScrollToElement(IWebElement element)
        {
            _driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
        }

        public void MouseOverElement(IWebElement element)
        {
            Actions action = new Actions(_driver);
            action.MoveToElement(element).Perform();
        }
    }
}
