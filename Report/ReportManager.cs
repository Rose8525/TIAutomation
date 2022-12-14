using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System.Reflection;

namespace TIAutomation.Report;
public class ReportManager
{
    private static ExtentHtmlReporter htmlReporter;

    private static ExtentReports extent;
    private static readonly object padlock = new object();

    private ReportManager(){ }

    public static ExtentReports GetInstance()
    {
        if (extent == null)
        {
            lock (padlock)
            {
                if (extent == null)
                {
                    string reportPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @".\Report\CreatedReport\TestReport.html";
                    htmlReporter = new ExtentHtmlReporter(reportPath);
                    extent = new ExtentReports();
                    extent.AttachReporter(htmlReporter);
                    extent.AddSystemInfo("Enviroment", "QA");

                    string extentConfigPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\extent-config.xml";
                    Console.WriteLine(extentConfigPath);
                    htmlReporter.LoadConfig(extentConfigPath);

                }
            }
        }
        return extent;
    }

    public static MediaEntityModelProvider ScreenShot(IWebDriver webDriver)
    {
        var screenshot = ((ITakesScreenshot)webDriver).GetScreenshot().AsBase64EncodedString;
        var mediaentity = MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot).Build();
        return mediaentity;
    }

    public static void FlushReport()
    {
        extent.Flush();
    }
}
