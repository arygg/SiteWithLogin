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
            startPage.LogIn.Click();

            // login link redirects to the login page
            var loginPage = browser.Page<LoginPage>();
            loginPage.Username.TypeText(username);
            loginPage.Password.TypeText(password);
            loginPage.LogIn.Click();
        }


        private static IE GetBrowserOnStartPage()
        {
            var browser = WebBrowserManager.GetBrowser();
            browser.GoTo(StartPage.StartPageUrl);
            return browser;
        }
    }
}