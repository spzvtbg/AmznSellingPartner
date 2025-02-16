namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `listDeliveryWindowOptions` response.
    /// </summary>
    public class ListDeliveryWindowOptionsResponse : BaseClass
    {
        /// <summary>
        /// Delivery window options generated for the placement option.
        /// </summary>
        [JsonProperty("deliveryWindowOptions")]
        [IsRequired]
        public List<DeliveryWindowOption> DeliveryWindowOptions { get; set; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }
    }
}
