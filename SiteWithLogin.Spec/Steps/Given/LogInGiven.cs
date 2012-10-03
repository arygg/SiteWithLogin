using System.Collections.Generic;

using SiteWithLogin.Spec.Steps.Drivers;
using SiteWithLogin.Spec.Steps.StepArguments;

using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps.Given
{
    [Binding]
    public class LogInGiven
    {
        [Given(@"I am on the start page")]
        public void GivenIAmOnTheStartPage()
        {
            new StartPageDriver().NavigateToStartPage();
        }

        [Given(@"I have a user with username ""(.*)"" and password ""(.*)""")]
        public void GivenIHaveAUserWithUsernameAndPassword(string username, string password)
        {
            new RegisterPageDriver().CreateUser(username, password);
        }

        [Given(@"these users")]
        public void GivenTheseUsers(IEnumerable<UserProperties> users)
        {
            var driver = new RegisterPageDriver();
            foreach (var userProperties in users)
            {
                driver.CreateUser(userProperties.Username, userProperties.Password);
            }
        }
    }
}