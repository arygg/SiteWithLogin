using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps.Then
{
    [Binding]
    public class LoginThen
    {
        [Then(@"the start page should display ""(.*)""")]
        public void ThenTheStartPageShouldDisplay(string p0)
        {

        } 
    }
}