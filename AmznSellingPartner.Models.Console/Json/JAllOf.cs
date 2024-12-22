namespace AmznSellingPartner.Models.Console.Json
{
    using System.Collections.Generic;

    public class JAllOf : JUnhandled
    {
        public string Description { get; set; }

        public string Ref { get; set; }

        public string Type { get; set; }

        public string[] Required { get; set; }

        public Dictionary<string, JProperty> Properties { get; set; }
    }
}