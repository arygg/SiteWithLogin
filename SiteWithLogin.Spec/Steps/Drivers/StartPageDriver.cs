using SiteWithLogin.Spec.Steps.Pages;

using WatiN.Core;

namespace SiteWithLogin.Spec.Steps.Drivers
{
    public class StartPageDriver
    {
        public void NavigateToStartPage()
        {
            GetBrowserOnStartPage();
        }

        public void LogInToSiteWithLogin(string username, string password)
        {
            var browser = GetBrowserOnStartPage();
            var startPage = browser.Page<StartPage>();
            
        }

        private static IE GetBrowserOnStartPage()
        {
            var browser = WebBrowserManager.GetBrowser();
            browser.GoTo(StartPage.StartPageUrl);
            return browser;
        }
    }
}