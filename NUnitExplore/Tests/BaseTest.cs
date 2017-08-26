using NUnit.Framework;
using NUnitExplore.Core;

namespace NUnitExplore.Test
{
    [TestFixture]
    [Parallelizable(ParallelScope.Children)]
    public class BaseTest:Driver
    {
        [SetUp]
        public void NavigateURL()
        {
            Driver.StartTest(BrowserType.chrome);
            driver.Url = "https://google.co.in";           
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();            
        }
    }
}
