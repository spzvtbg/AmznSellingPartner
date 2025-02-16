namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.HttpAttributes;

    using Newtonsoft.Json;

    public class AmznPostContentDocumentAsinRelationsResponse : BaseHttpResponse<AmznPostContentDocumentAsinRelationsResponse>
    {
        /// <summary>
        /// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the
        /// rate limit header is deprecated and no longer returned.
        /// </summary>
        [JsonProperty("x-amzn-ratelimit-limit")]
        public string XAmznRatelimitLimit { get; set; }

        /// <summary>
        /// Unique request reference identifier.
        /// </summary>
        [JsonProperty("x-amzn-requestid")]
        public string XAmznRequestid { get; set; }

        /// <summary>
        /// Success.
        /// </summary>
        [HttpStatus(200)]
        public PostContentDocumentAsinRelationsResponse PostContentDocumentAsinRelationsResponse { get; set; }

        /// <summary>
        /// Request has missing or invalid parameters and cannot be parsed. The request's Authorization
        /// header is not formatted correctly or does not contain a valid token. Indicates that access
        /// to the resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired
        /// Token, or Invalid Signature. The specified resource does not exist. The specified resource
        /// no longer exists. The frequency of requests was greater than allowed. An unexpected condition
        /// occurred that prevented the server from fulfilling the request. Temporary overloading or maintenance
        /// of the server.
        /// </summary>
        [HttpStatus(400)]
        [HttpStatus(401)]
        [HttpStatus(403)]
        [HttpStatus(404)]
        [HttpStatus(410)]
        [HttpStatus(429)]
        [HttpStatus(500)]
        [HttpStatus(503)]
        public ErrorList ErrorList { get; set; }
    }
}
