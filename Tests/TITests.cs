using AventStack.ExtentReports;
using NUnit.Framework;
using TIAutomation.Report;

namespace TIAutomation.Tests;

[TestFixture]
public class TITests : BaseTests
{
    public class Location
    {
        public int Position { get; }
        public string CityText { get; }

        public Location(int position, string cityText)
        {
            Position = position;
            CityText = cityText;
        }
    }

    static IEnumerable<Location> TestCities()
    {
        yield return new(0, "us");
        yield return new(1, "portugal");
        yield return new(2, "mexico");
        yield return new(3, "colombia");
        yield return new(4, "argentina");
        yield return new(5, "poland");
        yield return new(6, "ukraine");
    }

    [Test, Order(1)]
    public void WhenUserTriesAccededTIWebSite_ThenWebSiteRespondOK()
    {
        Assert.AreEqual("TEAM International | Empowering Innovative IT Software Solutions", initialPage.AccessWebSite());
        test.Log(Status.Pass, "TI WebSite succesfully acceded.", ReportManager.ScreenShot(_webDriver));
    }

    [Test, Order(2)]
    public void WhenUserScrollDown_ThenEachSectionIsShowed()
    {
        initialPage.NavigateAllSections();
        test.Log(Status.Pass, "Sroll sections works OK");
    }

    [Test, Order(3)]
    public void WhenUserMouseOverIndustrySubsectionsAndClickOnThem_ThenNewPageIsOpenOK()
    {
        Assert.AreEqual("Logistics and Transportation IT Solutions from TEAM International", initialPage.AccessToIndustryLogisticSubsection());
        Assert.AreEqual("IT Solutions for Oil & Gas Industry from TEAM International", initialPage.AccessToIndustryOilSubsection());
        Assert.AreEqual("IT Solutions for Telecom Industry as an Opportunity for Growth", initialPage.AccessToIndustryTelecomSubsection());
        Assert.AreEqual("Information Technology Teams - IT Solutions from TEAM International", initialPage.AccessToIndustryTechnologySubsection());
        Assert.AreEqual("Financial Services IT Solutions from TEAM International", initialPage.AccessToIndustryFinancialSubsection());
        Assert.AreEqual("Healthcare IT Solutions from TEAM International | Life Sciences IT Solutions", initialPage.AccessToIndustryHealthCareSubsection());
        Assert.AreEqual("IT Hospitality Solutions for Travel Industry from TEAM International", initialPage.AccessToIndustryTravelSubsection());
        Assert.AreEqual("Retail IT Solutions - How Can Digital Transformation Help Retailers & E-Tailers", initialPage.AccessToIndustryRetailSubsection());
        Assert.AreEqual("Digital Marketing & IT Solutions | TEAM International", initialPage.AccessToIndustryDigitalSubsection());
        test.Log(Status.Pass, "Industry Subsections links respond OK");
    }

    [Test, Order(4)]
    public void WhenUserMouseOverServicesSubsectionsAndClickOnThem_ThenNewPageIsOpenOK()
    {
        Assert.AreEqual("Software Outsourcing Solutions from Trusted Software Outsourcing Provider", initialPage.AccessToServicesSubsectionDev());
        Assert.AreEqual("Intelligent Automation Services | TEAM International", initialPage.AccessToServicesSubsectionAutomation());
        Assert.AreEqual("Software Testing Solutions and QA | TEAM International", initialPage.AccessToServicesSubsectionQA());
        Assert.AreEqual("Microsoft Solutions from TEAM: App Development & Azure Migration", initialPage.AccessToServicesSubsectionMicrosoft());
        Assert.AreEqual("IT Consulting Services from True Professionals | TEAM International", initialPage.AccessToServicesSubsectionConsulting());
        Assert.AreEqual("Data Analytics Services | Data Analytics Solutions from TEAM International", initialPage.AccessToServicesSubsectionAnalytics());
        Assert.AreEqual("Managed IT Services and Solutions from TEAM International", initialPage.AccessToServicesSubsectionManaged());
        test.Log(Status.Pass, "Services Subsections links respond OK");
    }

    [Test, Order(5)]
    public void WhenUserMouseOverClientSubsections_ChangeColorIconOK()
    {
        initialPage.AccessToTheyTrustUsSubsection();
        test.Log(Status.Pass, "Client Subsections logos change colors OK", ReportManager.ScreenShot(_webDriver));
    }

    [Test, Order(6)]
    public void WhenClickSeeAllLocationsSubsections_RespondOK()
    {
        foreach (var l in TestCities())
        {
            var title = initialPage.AccessToLocationsSubsection(l.Position);
            Assert.IsTrue(title.Contains(l.CityText));
        }
        test.Log(Status.Pass, "Locations Subsections respond OK");
    }

    [Test, Order(7)]
    public void WhenClickSeeMoreCoursesSubsections_RespondOK()
    {
        var title = initialPage.AccessToServicesSubsectionTopGun();
        Assert.AreEqual("IT Education by TEAM International - learning opportunities for everyone", title);
        test.Log(Status.Pass, "Top Gun Lab SeeMore Subsections respond OK", ReportManager.ScreenShot(_webDriver));
    }

    [Test, Order(8)]
    public void WhenClickSeeAllCareersSubsections_RespondOK()
    {
        var title = initialPage.AccessToCareersSubsection();
        Assert.AreEqual("Careers", title);
        test.Log(Status.Pass, "Careers Subsections respond OK", ReportManager.ScreenShot(_webDriver));
    }
    
    [Test, Order(9)]
    public void WhenUserFillContactUsForm_ThenEmailIsSentOk()
    {
        var response = initialPage.FillContactForm();
        Assert.AreEqual("THANK YOU FOR CONTACTING US!", response);
        test.Log(Status.Pass, "Email contact message sent OK.", ReportManager.ScreenShot(_webDriver));
    }
}


