using WatiN.Core;

namespace SiteWithLogin.Spec.Steps.Pages
{
    public class StartPage : Page
    {
        public const string StartPageUrl = "http://localhost:63856/";

        public Link LogOut { get { return Document.Link(Find.ByText("Log off")); } }
        public Link LogIn { get { return Document.Link(Find.ByText("Log in")); } }
    }
}