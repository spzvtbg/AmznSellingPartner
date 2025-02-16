namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// An Amazon order item identifier and a quantity.
    /// </summary>
    public class Item : BaseClass
    {
        [JsonProperty("OrderItemId")]
        [IsRequired]
        public OrderItemId OrderItemId { get; set; }

        [JsonProperty("Quantity")]
        [IsRequired]
        public ItemQuantity Quantity { get; set; }

        [JsonProperty("ItemWeight")]
        public Weight ItemWeight { get; set; }

        [JsonProperty("ItemDescription")]
        public ItemDescription ItemDescription { get; set; }

        [JsonProperty("TransparencyCodeList")]
        public TransparencyCodeList TransparencyCodeList { get; set; }

        /// <summary>
        /// A list of additional seller inputs required to ship this item using the chosen shipping se
        /// rvice.
        /// </summary>
        [JsonProperty("ItemLevelSellerInputsList")]
        public AdditionalSellerInputsList ItemLevelSellerInputsList { get; set; }

        [JsonProperty("LiquidVolume")]
        public LiquidVolume LiquidVolume { get; set; }

        /// <summary>
        /// When true, the item qualifies as hazardous materials (hazmat). Defaults to false.
        /// </summary>
        [JsonProperty("IsHazmat")]
        public bool IsHazmat { get; set; }

        [JsonProperty("DangerousGoodsDetails")]
        public DangerousGoodsDetails DangerousGoodsDetails { get; set; }
    }
}
