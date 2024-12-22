namespace AmznSellingPartner.Models.Console.CSharp
{
    using System.Collections.Generic;

    public class CSNamespace
    {
        public string Name { get; set; }

        public IEnumerable<CSClass> Classes { get; set; }
    }
}
