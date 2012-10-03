using Simple.Data;
using TechTalk.SpecFlow;

namespace SiteWithLogin.Spec.Steps
{
    [Binding]
    public class DatabaseSetup
    {
        private static readonly dynamic DbConnection = Database.OpenNamedConnection("Simple.Data");

        [BeforeScenario("login")]
        public void ClearAllMembershipData()
        {
            DbConnection.webpages_Membership.DeleteAll();
            DbConnection.UserProfile.DeleteAll();
        }

//select * from UserProfile
//select * from webpages_Membership
    }
}