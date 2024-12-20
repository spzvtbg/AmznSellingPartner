namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JResponse : JUnhandled
    {
        public string Description { get; set; }

        public JSchema Schema { get; set; }

        public JHeaders Headers { get; set; }

        [JsonProperty("x-amzn-api-sandbox")]
        public JSandbox Sandbox { get; set; }

        [JsonProperty("x-amazon-spds-sandbox-behaviors")]
        public JToken Behaviors { get; set; }

        public JToken Examples { get; set; }
    }
}