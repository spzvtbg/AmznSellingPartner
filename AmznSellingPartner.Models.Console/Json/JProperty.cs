namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JProperty : JUnhandled
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public string Ref { get; set; }

        public JProperty Items { get; set; }

        public string Format { get; set; }

        public int MinItems { get; set; }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public int MaxItems { get; set; }

        public int Maximum { get; set; }

        public int Minimum { get; set; }

        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public JEnum[] EnumValues { get; set; }

        public string Pattern { get; set; }

        public JToken AdditionalProperties { get; set; }

        public string[] Required { get; set; }

        public bool UniqueItems { get; set; }

        public JToken Default { get; set; }

        public JToken Example { get; set; }

        public JToken MultipleOf { get; set; }
    }
}