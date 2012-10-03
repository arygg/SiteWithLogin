using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps.When
{
    [Binding]
    public class LogInWhen
    {
        [When(@"I log in with the username ""(.*)"" and the password ""(.*)""")]
        public void WhenILogInWithTheUsernameAndThePassword(string username, string password)
        {
        }
    }
}