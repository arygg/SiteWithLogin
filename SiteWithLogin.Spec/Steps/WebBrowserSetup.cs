using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps
{
    [Binding]
    public class WebBrowserSetup
    {
        [AfterScenario()]
        public void KillBrowsers()
        {
            WebBrowserManager.CloseBrowser();
        }
    }
}