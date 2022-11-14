using AventStack.ExtentReports;
using AventStack.ExtentReports.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using TIAutomation.PageObjects;
using TIAutomation.Report;
using TIAutomation.WebDriverImplementation;

namespace TIAutomation.Tests
{
    public class BaseTests
    {
        protected IWebDriver _webDriver;
        private string url = "https://www.teaminternational.com/";
        private ExtentReports report;
        protected ExtentTest test;
        protected TIMainPage initialPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            report = ReportManager.GetInstance();
        }

        [SetUp]
        public void SetUp()
        {
            var browser = Utils.Config.Get("browser"); 
            _webDriver = WebDriverFactory.GetDriver(browser);
            test = report.CreateTest(TestContext.CurrentContext.Test.Name);
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(url);
            initialPage = new TIMainPage(_webDriver);
        }

        [TearDown]
        public void TearDown()
        {
            ReportManager.FlushReport();
            if (_webDriver != null)
                _webDriver.Quit();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ReportManager.FlushReport();
            if (_webDriver != null)
                _webDriver.Quit();
        }
    }
}
