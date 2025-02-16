namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    /// <summary>
    /// Information about an item associated with the service job.
    /// </summary>
    public class AssociatedItem : BaseClass
    {
        /// <summary>
        /// The Amazon Standard Identification Number (ASIN) of the item.
        /// </summary>
        [JsonProperty("asin")]
        public string Asin { get; set; }

        /// <summary>
        /// The title of the item.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The total number of items included in the order.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// The Amazon-defined identifier for an order placed by the buyer in 3-7-7 format.
        /// </summary>
        [JsonProperty("orderId")]
        public OrderId OrderId { get; set; }

        /// <summary>
        /// The status of the item.
        /// </summary>
        [JsonProperty("itemStatus")]
        public ItemStatus ItemStatus { get; set; }

        /// <summary>
        /// The brand name of the item.
        /// </summary>
        [JsonProperty("brandName")]
        public string BrandName { get; set; }

        /// <summary>
        /// Delivery information for the item.
        /// </summary>
        [JsonProperty("itemDelivery")]
        public ItemDelivery ItemDelivery { get; set; }
    }
}
