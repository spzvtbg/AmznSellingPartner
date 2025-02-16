namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Input for to be uploaded document.
    /// </summary>
    public class ServiceUploadDocument : BaseClass
    {
        /// <summary>
        /// The content type of the to-be-uploaded file
        /// </summary>
        [JsonProperty("contentType")]
        [IsRequired]
        public ContentType ContentType { get; set; }

        /// <summary>
        /// The content length of the to-be-uploaded file
        /// </summary>
        [JsonProperty("contentLength")]
        [IsRequired]
        [Minimum(1)]
        [Maximum(5242880)]
        public long ContentLength { get; set; }

        /// <summary>
        /// An MD5 hash of the content to be submitted to the upload destination. This value is used to
        /// determine if the data has been corrupted or tampered with during transit.
        /// </summary>
        [JsonProperty("contentMD5")]
        [Pattern("^[A-Za-z0-9\\\\+/]{22}={2}")]
        public string ContentMD5 { get; set; }
    }
}
