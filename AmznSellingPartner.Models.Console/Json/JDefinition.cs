namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JDefinition : JUnhandled
    {
        public string Description { get; set; }

        public JAllOf[] AllOf { get; set; }

        public JProperties Properties { get; set; }

        public JProperty Items { get; set; }

        public JToken AdditionalProperties { get; set; }

        public string[] Required { get; set; }

        // "object",
        // "string",
        // "array",
        // "number",
        // "integer",
        // "boolean"
        public string Type { get; set; }

        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public JEnum[] EnumValues { get; set; }

        public bool UniqueItems { get; set; }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public int MinItems { get; set; }

        public int MaxItems { get; set; }

        // "float",
        // "date-time",
        // "double",
        // "date",
        // "int32",
        // "int64",
        // "ip",
        // "byte"
        public string Format { get; set; }

        // "^([a-zA-Z0-9_\\-\\.]+)@([a-zA-Z0-9_\\-\\.]+)\\.([a-zA-Z]{2,5})"
        public string Pattern { get; set; }

        public double Minimum { get; set; }

        public JToken Example { get; set; }

        [JsonProperty("x-example")]
        public JToken XExample { get; set; }
    }
}