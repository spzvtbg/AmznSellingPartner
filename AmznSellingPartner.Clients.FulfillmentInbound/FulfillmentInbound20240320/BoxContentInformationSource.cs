namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    /// <summary>
    /// Indication of how box content is meant to be provided.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BoxContentInformationSource
    {
        /// <summary>
        /// Box contents have been provided by the seller.
        /// </summary>
        [EnumMember(Value = "BOX_CONTENT_PROVIDED")]
        BOX_CONTENT_PROVIDED,

        /// <summary>
        /// Box contents will be manually processed during receive. This service incurs charges.
        /// </summary>
        [EnumMember(Value = "MANUAL_PROCESS")]
        MANUAL_PROCESS,

        /// <summary>
        /// Box contents information is provided by a barcode on the shipment. For more information, refer
        /// to [Using 2D barcodes for box content information](https://sellercentral.amazon.com/help/hub/reference/GJWALJCN6JKWJX5A)
        /// on Seller Central.
        /// </summary>
        [EnumMember(Value = "BARCODE_2D")]
        BARCODE_2D,
    }
}
