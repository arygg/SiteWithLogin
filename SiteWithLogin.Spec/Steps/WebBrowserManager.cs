using System;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace SiteWithLogin.Spec.Steps
{
    public static class WebBrowserManager
    {
        private const string BROWSER_KEY = "BROWSER_KEY";
        public static IE GetBrowser()
        {
            if (ScenarioContext.Current.ContainsKey(BROWSER_KEY))
            {
                return ScenarioContext.Current.Get<IE>(BROWSER_KEY);
            }

            var browser = new IE();
            ScenarioContext.Current.Add(BROWSER_KEY, browser);
            return browser;
        }

        public static void CloseBrowser()
        {
            if (ScenarioContext.Current.ContainsKey(BROWSER_KEY))
                ScenarioContext.Current.Get<IE>(BROWSER_KEY).Dispose();
        }
    }
}