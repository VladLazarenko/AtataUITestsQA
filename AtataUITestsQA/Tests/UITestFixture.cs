using Atata;
using AtataUITestsQA.Components;
using NUnit.Framework;
using OpenQA.Selenium;
using Atata.ExtentReports;
using AtataApp.UITests.Components.StepDefinitions;

namespace AtataUITestsQA
{
    //[TestFixture]
    //[Parallelizable(ParallelScope.Self)]
    //public class UITestFixture
    //{
    //    public IWebDriver webdriver;

    //    [SetUp]
    //    public void SetUp()
    //    {
    //        AtataContext.Configure()
    //            .UseChrome()
    //            .WithArguments("ignore-certificate-errors", "start-maximized", "disable-infobars")
    //            .UseCulture("en-US")
    //            .UseAllNUnitFeatures()
    //            .Build();
    //    }

    //    [TearDown]
    //    public void TearDown()
    //    {
    //        AtataContext.Current?.CleanUp();
    //    }
    //}

    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    //[Parallelizable(ParallelScope.Fixtures)]
    public class UITestFixture : BaseSteps
    {
        protected AtataContext FixtureContext { get; set; }

        protected virtual bool UseFixtureDriverForTests => false;

        [OneTimeSetUp]
        public void InitFixtureContext() =>
            FixtureContext = AtataContext.Configure()
                .UseDriverInitializationStage(AtataContextDriverInitializationStage.OnDemand)
                .LogConsumers.Add<ExtentLogConsumer>()
                    .WithMinLevel(Atata.LogLevel.Warn)
                    .UseBaseUrl("https://qa.datatodeals.com/")
                .Build();

        [OneTimeTearDown]
        public void DisposeFixtureContext() =>
            FixtureContext?.Dispose();

        [SetUp]
        public void SetUp()
        {
            var testContextBuilder = AtataContext.Configure()
                .LogConsumers.Add<ExtentLogConsumer>();

            if (UseFixtureDriverForTests)
                testContextBuilder.UseDriver(FixtureContext.Driver);

            testContextBuilder.Build();
        }

        [TearDown]
        public void TearDown() =>
            AtataContext.Current?.CleanUp(quitDriver: !UseFixtureDriverForTests);

        protected virtual TPageObject BeingOn<TPageObject>()
            where TPageObject : PageObject<TPageObject>
            =>
            Go.To<TPageObject>(navigate: false);
    }
}
