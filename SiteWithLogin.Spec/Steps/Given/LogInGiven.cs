using SiteWithLogin.Spec.Steps.Drivers;

using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps.Given
{
    [Binding]
    public class LogInGiven
    {
        [Given(@"I am on the start page")]
        public void GivenIAmOnTheStartPage()
        {
            // go to start page
        }

        [Given(@"I have a user with username ""(.*)"" and password ""(.*)""")]
        public void GivenIHaveAUserWithUsernameAndPassword(string username, string password)
        {
            new RegisterPageDriver().CreateUser(username, password);
        }
    }
}