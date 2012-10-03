using SiteWithLogin.Spec.Steps.Drivers;

using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps.When
{
    [Binding]
    public class LogInWhen
    {
       [Given(@"these valves(?: and valve groups)?")]
        [When(@"I(?: try to)? log in with the username ""(.*)"" and the password ""(.*)""")]
        public void WhenILogInWithTheUsernameAndThePassword(string username, string password)
        {
            new StartPageDriver().LogInToSiteWithLogin(username, password);
        }
    }
}