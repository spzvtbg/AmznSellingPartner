namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;

    public class JItem : JUnhandled
    {
        public string Type { get; set; }

        public int MinLength { get; set; }

        public int MaxLength { get; set; }

        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public JEnum[] EnumValues { get; set; }
    }
}
