namespace AmznSellingPartner.Models.Console.Json
{
    using AmznSellingPartner.Models.Console.CSharp;

    using System.Collections.Generic;

    public class JDefinitions : Dictionary<string, JDefinition>
    {
        public IEnumerable<CSClass> ToCSClasses()
        {
            var csClasses = new List<CSClass>();

            foreach (var definition in this.Values)
            {
                csClasses.Add(definition.ToCSClass());
            }

            return csClasses;
        }
    }
}
