namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
    using AmznSellingPartner.Clients.HttpAttributes;

    using Newtonsoft.Json;

    public class AmznGetItemEligibilityPreviewResponse : BaseHttpResponse<AmznGetItemEligibilityPreviewResponse>
    {
        /// <summary>
        /// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the
        /// rate limit header is deprecated and no longer returned.
        /// </summary>
        [JsonProperty("x-amzn-ratelimit-limit")]
        public string XAmznRatelimitLimit { get; set; }

        /// <summary>
        /// Unique request reference ID.
        /// </summary>
        [JsonProperty("x-amzn-requestid")]
        public string XAmznRequestid { get; set; }

        /// <summary>
        /// Success. Request has missing or invalid parameters and cannot be parsed. The request's Authorization
        /// header is not formatted correctly or does not contain a valid token. 403 can be caused for
        /// reasons like Access Denied, Unauthorized, Expired Token, Invalid Signature or Resource Not
        /// Found. The resource specified does not exist. The frequency of requests was greater than allowed.
        /// Encountered an unexpected condition which prevented the server from fulfilling the request.
        /// Temporary overloading or maintenance of the server.
        /// </summary>
        [HttpStatus(200)]
        [HttpStatus(400)]
        [HttpStatus(401)]
        [HttpStatus(403)]
        [HttpStatus(404)]
        [HttpStatus(429)]
        [HttpStatus(500)]
        [HttpStatus(503)]
        public GetItemEligibilityPreviewResponse GetItemEligibilityPreviewResponse { get; set; }
    }
}
