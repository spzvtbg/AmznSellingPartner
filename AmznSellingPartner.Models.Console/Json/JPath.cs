namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;

    public class JPath : JUnhandled
    {
        public JMethod Get { get; set; }

        public JMethod Delete { get; set; }

        public JMethod Patch { get; set; }

        public JMethod Post { get; set; }

        public JMethod Put { get; set; }

        public JParameter[] Parameters { get; set; }

        [JsonProperty("x-amzn-api-sandbox-only")]
        public bool SandboxOnly { get; set; }

        [JsonProperty("x-amzn-api-sandbox")]
        public JSandbox Sandbox { get; set; }
    }
}