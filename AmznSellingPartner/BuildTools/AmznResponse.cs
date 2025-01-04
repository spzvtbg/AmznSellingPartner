namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class AmznResponse : AmznUnhandled
    {
        public string Description { get; set; }

        public AmznSchema Schema { get; set; }

        public AmznHeaders Headers { get; set; }

        [JsonProperty("x-amzn-api-sandbox")]
        public JToken Sandbox { get; set; }

        [JsonProperty("x-amazon-spds-sandbox-behaviors")]
        public JToken Behaviors { get; set; }

        public JToken Examples { get; set; }

        internal CsProperty OnDeserialized(string status, CsContext context)
              => new CsProperty
              {
                  Name = this.Schema?.Ref?.GetReferenceType() ?? "Object",
                  Type = this.Schema?.Ref?.GetReferenceType() ?? "object"
              }
              .HasDescription(this.Description);
    }
}