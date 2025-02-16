namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The document specifications requested. For calls to the purchaseShipment operation, the shipment
    /// purchase fails if the specified document specifications are not among those returned in the
    /// response to the getRates operation.
    /// </summary>
    public class RequestedDocumentSpecification : BaseClass
    {
        [JsonProperty("format")]
        [IsRequired]
        public DocumentFormat Format { get; set; }

        [JsonProperty("size")]
        [IsRequired]
        public DocumentSize Size { get; set; }

        [JsonProperty("dpi")]
        public Dpi Dpi { get; set; }

        [JsonProperty("pageLayout")]
        public PageLayout PageLayout { get; set; }

        [JsonProperty("needFileJoining")]
        [IsRequired]
        public NeedFileJoining NeedFileJoining { get; set; }

        /// <summary>
        /// A list of the document types requested.
        /// </summary>
        [JsonProperty("requestedDocumentTypes")]
        [IsRequired]
        public List<DocumentType> RequestedDocumentTypes { get; set; }
    }
}
