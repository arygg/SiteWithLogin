using WatiN.Core;

namespace SiteWithLogin.Spec.Steps.Pages
{
    public class LoginPage : Page
    {
        private const string LoginPageUrl = "http://localhost:63856/Account/Login";

        public TextField Username { get { return Document.TextField("UserName"); } }
        public TextField Password { get { return Document.TextField("Password"); } }
        public Link LogIn { get { return Document.Link(Find.ByText("Log in")); } }
    }
}