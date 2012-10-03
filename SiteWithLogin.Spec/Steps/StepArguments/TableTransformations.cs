using System.Collections.Generic;

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SiteWithLogin.Spec.Steps.StepArguments
{
    [Binding]
    public class TableTransformations
    {
        [StepArgumentTransformation]
        public IEnumerable<UserProperties> ConvertTableToUserPropertyList(Table table)
        {
            return table.CreateSet<UserProperties>();
        }
    }
}