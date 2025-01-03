namespace AmznSellingPartner
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;

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

        internal IEnumerable<CsProperty> OnDeserialized(string status, CsContext context)
        {
            foreach (var csProperty in (this.Headers ?? []).OnDeserialized(context))
            {
                yield return csProperty;
            }

            yield return new CsProperty
            {
                Name = $"Value{status}",
                Type = this.Schema?.Ref?.GetReferenceType() ?? "object"
            }
            .HasDescription(this.Description);
        }
    }
}