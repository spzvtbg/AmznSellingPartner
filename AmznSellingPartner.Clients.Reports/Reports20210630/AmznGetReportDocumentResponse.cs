namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
    using AmznSellingPartner.Clients.HttpAttributes;

    using Newtonsoft.Json;

    public class AmznGetReportDocumentResponse : BaseHttpResponse<AmznGetReportDocumentResponse>
    {
        /// <summary>
        /// Your rate limit (requests per second) for this operation.
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
        public ReportDocument ReportDocument { get; set; }

        /// <summary>
        /// Request has missing or invalid parameters and cannot be parsed. The request's Authorization
        /// header is not formatted correctly or does not contain a valid token. Indicates access to the
        /// resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired Token,
        /// or Invalid Signature. The specified resource does not exist. The request's Content-Type header
        /// is invalid. The frequency of requests was greater than allowed. An unexpected condition occurred
        /// that prevented the server from fulfilling the request. Temporary overloading or maintenance
        /// of the server.
        /// </summary>
        [HttpStatus(400)]
        [HttpStatus(401)]
        [HttpStatus(403)]
        [HttpStatus(404)]
        [HttpStatus(415)]
        [HttpStatus(429)]
        [HttpStatus(500)]
        [HttpStatus(503)]
        public ErrorList ErrorList { get; set; }
    }
}
