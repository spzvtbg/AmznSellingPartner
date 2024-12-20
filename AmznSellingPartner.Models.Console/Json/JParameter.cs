namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;

    public class JParameter : JUnhandled
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string In { get; set; }

        public int MinLength { get; set; }

        public bool Required { get; set; }

        // "string"
        // "integer"
        // "array"
        // "boolean"
        // "number"
        public string Type { get; set; }

        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public JEnum[] EnumValues { get; set; }

        [JsonProperty("x-example")]
        public string XExample { get; set; }

        // "date-time"
        // "int32"
        // "date"
        // "[A-Z]{2}"
        // "int64"
        // "boolean"
        public string Format { get; set; }

        public object Default { get; set; }

        public int Maximum { get; set; }

        public int Minimum { get; set; }

        public JSchema Schema { get; set; }

        public JItem Items { get; set; }

        // "csv", "multi"
        public string CollectionFormat { get; set; }

        public int MinItems { get; set; }

        public bool UniqueItems { get; set; }

        public int MaxItems { get; set; }

        public int MaxLength { get; set; }

        // "^[a-zA-Z0-9-]*$"
        // "[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}"
        // "^[A-Z0-9_]*$","^[a-zA-Z0-9]+$"
        public string Pattern { get; set; }

        [JsonProperty("x-amazon-spds-greedy-path-parameter")]
        public bool SpdsGreadyPathParameter { get; set; }

        public string Ref { get; set; }
    }
}