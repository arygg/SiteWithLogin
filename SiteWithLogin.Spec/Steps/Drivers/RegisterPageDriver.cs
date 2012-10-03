using SiteWithLogin.Spec.Steps.Pages;

namespace SiteWithLogin.Spec.Steps.Drivers
{
    public class RegisterPageDriver
    {
        public void CreateUser(string username, string password)
        {
            var ie = WebBrowserManager.GetBrowser();
            ie.GoTo(RegisterPage.RegisterPageUrl);
            
            var registerPage = ie.Page<RegisterPage>();
            registerPage.UserName.TypeText(username);
            registerPage.Password.TypeText(password);
            registerPage.ConfirmPassword.TypeText(password);
            registerPage.Register.Click();
            // register page redirects to the start page after registration
            var startPage = ie.Page<StartPage>();
            startPage.LogOut.Click();
        }
    }
}