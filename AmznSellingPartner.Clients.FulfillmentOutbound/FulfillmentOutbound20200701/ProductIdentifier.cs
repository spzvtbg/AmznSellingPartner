namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Product identifier input that locates a product for MCF.
    /// </summary>
    public class ProductIdentifier : BaseClass
    {
        /// <summary>
        /// The merchant SKU for the product.
        /// </summary>
        [JsonProperty("merchantSku")]
        [IsRequired]
        [MaxLength(50)]
        public string MerchantSku { get; set; }
    }
}
