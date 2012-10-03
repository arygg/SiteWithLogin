using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps.Then
{
    [Binding]
    public class LoginThen
    {
        [Then(@"the current page should display ""(.*)""")]
        [Then(@"the login page should display ""(.*)""")]
        [Then(@"the start page should display ""(.*)""")]
        public void ThenTheStartPageShouldDisplay(string expectedDisplayMessage)
        {
            var browser = WebBrowserManager.GetBrowser();
            Assert.That(
                browser.ContainsText(expectedDisplayMessage),
                Is.True,
                "Cannot find the expected display text \"" + expectedDisplayMessage + "\"");
        }
    }
}