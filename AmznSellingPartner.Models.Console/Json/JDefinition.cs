namespace AmznSellingPartner.Models.Console.Json
{
    using AmznSellingPartner.Models.Console.CSharp;

    using Newtonsoft.Json;

    public class JDefinition : JUnhandled
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public JProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] RequiredProperties { get; set; }

        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public JEnum[] EnumValues { get; set; }

        public CSClass ToCSClass()
        {
            var csClass = new CSClass();

            csClass.Summary = this.Description.ToSummaryRows();

            if (this.Type == "object")
            {
                csClass.Type = "class";
            }
            else if (this.Type == "string")
            {
                csClass.Type = "enum";
            }

            csClass.Name = this.Name;

            return csClass;
        }
    }
}