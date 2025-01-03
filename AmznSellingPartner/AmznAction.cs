namespace AmznSellingPartner
{
    using AmznSellingPartner.Clients;

    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;

    using System.Linq;

    internal class AmznAction : AmznUnhandled
    {
        public string OperationId { get; set; }

        public string Description { get; set; }

        public bool? Deprecated { get; set; }

        public AmznParameter[] Parameters { get; set; }

        [JsonProperty("x-amzn-api-sandbox-only")]
        public bool? SandboxOnly { get; set; }

        [JsonProperty("x-amzn-api-sandbox")]
        public JToken Sandbox { get; set; }

        public string[] Tags { get; set; }

        public string[] Consumes { get; set; }

        public string[] Produces { get; set; }

        public string Summary { get; set; }

        public AmznResponses Responses { get; set; }

        internal void OnDeserialized(string method, string route, CsContext context, AmznParameters parameters)
        {
            var operation = this.OperationId.Capitalize();
            var csRequest = context.GetOrCreateClass($"{operation}{method}Request");
            csRequest.HasAttribute($"Http{method}", $"\"{route}\"")
                     .Inherits(nameof(BaseHttpRequest));

            foreach (var parameter in this.Parameters ?? [])
            {
                var csProperty = parameter?.OnDeserialized(csRequest, context, parameters);

                csRequest.HasProperty(csProperty);
            }

            var csResponse = context.GetOrCreateClass($"{operation}{method}Response");
            csResponse.Inherits($"BaseHttpResponse<{csResponse.GetTypeName()}>");

            foreach (var csProeprty in this.Responses.OnDeserialized(context))
            {
                csResponse.HasProperty(csProeprty);
            }

            var csMethod = new CsMethod($"{operation}Async")
                .HasDescription(this.Description)
                .HasRequestType(csRequest.GetTypeName())
                .HasResponseType(csResponse.GetTypeName())
                .IsDeprecated(this.Deprecated == true);

            if (this.Tags is null)
            {
                var tag = route
                    .Split('/', System.StringSplitOptions.RemoveEmptyEntries)
                    .FirstOrDefault()
                    .Capitalize();

                this.Tags = [ tag ];
            }

            foreach (var tag in this.Tags)
            {
                context.GetOrCreateClient(tag)
                       .HasMethod(csMethod)
                       .Inherits(nameof(BaseHttpClient));
            }
        }
    }
}