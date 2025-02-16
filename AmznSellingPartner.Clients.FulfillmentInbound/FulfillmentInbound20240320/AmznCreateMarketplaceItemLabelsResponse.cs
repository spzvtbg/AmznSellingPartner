namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.HttpAttributes;

    using Newtonsoft.Json;

    public class AmznCreateMarketplaceItemLabelsResponse : BaseHttpResponse<AmznCreateMarketplaceItemLabelsResponse>
    {
        /// <summary>
        /// Unique request reference identifier.
        /// </summary>
        [JsonProperty("x-amzn-requestid")]
        public string XAmznRequestid { get; set; }

        /// <summary>
        /// Your rate limit (requests per second) for this operation.
        /// </summary>
        [JsonProperty("x-amzn-ratelimit-limit")]
        public string XAmznRatelimitLimit { get; set; }

        /// <summary>
        /// CreateMarketplaceItemLabels 200 response
        /// </summary>
        [HttpStatus(200)]
        public CreateMarketplaceItemLabelsResponse CreateMarketplaceItemLabelsResponse { get; set; }

        /// <summary>
        /// Request has missing or invalid parameters and cannot be parsed. The resource specified does
        /// not exist. An unexpected condition occurred that prevented the server from fulfilling the request.
        /// Indicates that access to the resource is forbidden. Possible reasons include Access Denied,
        /// Unauthorized, Expired Token, or Invalid Signature. The request size exceeded the maximum accepted
        /// size. The request payload is in an unsupported format. The frequency of requests was greater
        /// than allowed. Temporary overloading or maintenance of the server.
        /// </summary>
        [HttpStatus(400)]
        [HttpStatus(404)]
        [HttpStatus(500)]
        [HttpStatus(403)]
        [HttpStatus(413)]
        [HttpStatus(415)]
        [HttpStatus(429)]
        [HttpStatus(503)]
        public ErrorList ErrorList { get; set; }
    }
}
