using WatiN.Core;

namespace SiteWithLogin.Spec.Steps.Pages
{
    public class RegisterPage : Page
    {
        public const string RegisterPageUrl = "http://localhost:63856/Account/Register";

        public TextField UserName { get { return Document.TextField("UserName"); } }
        public TextField Password { get { return Document.TextField("Password"); } }
        public TextField ConfirmPassword { get { return Document.TextField("ConfirmPassword"); } }
        public Button Register { get { return Document.Button("Register"); } }
    }
}