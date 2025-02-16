namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The format options available for a label.
    /// </summary>
    public class PrintOption : BaseClass
    {
        /// <summary>
        /// A list of the supported DPI options for a document.
        /// </summary>
        [JsonProperty("supportedDPIs")]
        public List<Dpi> SupportedDPIs { get; set; }

        /// <summary>
        /// A list of the supported page layout options for a document.
        /// </summary>
        [JsonProperty("supportedPageLayouts")]
        [IsRequired]
        public List<PageLayout> SupportedPageLayouts { get; set; }

        /// <summary>
        /// A list of the supported needFileJoining boolean values for a document.
        /// </summary>
        [JsonProperty("supportedFileJoiningOptions")]
        [IsRequired]
        public List<NeedFileJoining> SupportedFileJoiningOptions { get; set; }

        /// <summary>
        /// A list of the supported documented details.
        /// </summary>
        [JsonProperty("supportedDocumentDetails")]
        [IsRequired]
        public List<SupportedDocumentDetail> SupportedDocumentDetails { get; set; }
    }
}
