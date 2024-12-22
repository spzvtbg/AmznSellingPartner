namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    public class JMethod : JUnhandled
    {
        public string OperationId { get; set; }

        public string Description { get; set; }

        public string Summary { get; set; }

        public bool Deprecated { get; set; }

        public string[] Tags { get; set; }

        public string[] Consumes { get; set; }

        public string[] Produces { get; set; }

        public JParameter[] Parameters { get; set; }

        public JResponses Responses { get; set; }

        [JsonProperty("x-amzn-api-sandbox-only")]
        public bool SandboxOnly { get; set; }

        [JsonProperty("x-amzn-api-sandbox")]
        public JSandbox Sandbox { get; set; }

        internal void GetSchemas(HashSet<string> schemas)
        {
            if (this.Tags?.Length > 0)
            {
                foreach (var tag in this.Tags)
                {
                    schemas.Add(tag);
                }
            }
        }
    }
}