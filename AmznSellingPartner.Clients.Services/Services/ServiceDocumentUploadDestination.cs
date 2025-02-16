namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Information about an upload destination.
    /// </summary>
    public class ServiceDocumentUploadDestination : BaseClass
    {
        /// <summary>
        /// The unique identifier to be used by APIs that reference the upload destination.
        /// </summary>
        [JsonProperty("uploadDestinationId")]
        [IsRequired]
        public string UploadDestinationId { get; set; }

        /// <summary>
        /// The URL to which to upload the file.
        /// </summary>
        [JsonProperty("url")]
        [IsRequired]
        public string Url { get; set; }

        [JsonProperty("encryptionDetails")]
        [IsRequired]
        public EncryptionDetails EncryptionDetails { get; set; }

        /// <summary>
        /// The headers to include in the upload request.
        /// </summary>
        [JsonProperty("headers")]
        public Headers Headers { get; set; }
    }
}
