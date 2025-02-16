namespace AmznSellingPartner.Clients.Uploads.Uploads20201101
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    [HttpPost("/uploads/2020-11-01/uploadDestinations/{resource}")]
    public class AmznCreateUploadDestinationForResourceRequest : BaseHttpRequest
    {
        /// <summary>
        /// A list of marketplace identifiers. This specifies the marketplaces where the upload will be
        /// available. Only one marketplace can be specified.
        /// </summary>
        [InQuery("marketplaceIds")]
        [IsRequired]
        [MaxItems(1)]
        public CsvValue<string> MarketplaceIds { get; set; }

        /// <summary>
        /// An MD5 hash of the content to be submitted to the upload destination. This value is used to
        /// determine if the data has been corrupted or tampered with during transit.
        /// </summary>
        [InQuery("contentMD5")]
        [IsRequired]
        public string ContentMD5 { get; set; }

        /// <summary>
        /// The resource for the upload destination that you are creating. For example, if you are creating
        /// an upload destination for the createLegalDisclosure operation of the Messaging API, the `{resource}`
        /// would be `/messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure`, and the entire path
        /// would be `/uploads/2020-11-01/uploadDestinations/messaging/v1/orders/{amazonOrderId}/messages/legalDisclosure`.
        /// If you are creating an upload destination for an Aplus content document, the `{resource}` would
        /// be `aplus/2020-11-01/contentDocuments` and the path would be `/uploads/v1/uploadDestinatio
        /// ns/aplus/2020-11-01/contentDocuments`.
        /// </summary>
        [InPath("resource")]
        [IsRequired]
        public string Resource { get; set; }

        /// <summary>
        /// The content type of the file to be uploaded.
        /// </summary>
        [InQuery("contentType")]
        public string ContentType { get; set; }
    }
}
