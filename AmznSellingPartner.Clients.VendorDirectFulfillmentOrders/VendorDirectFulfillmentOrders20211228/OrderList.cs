namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of purchase orders.
    /// </summary>
    public class OrderList : BaseClass
    {
        /// <summary>
        /// The pagination elements required to retrieve the remaining data.
        /// </summary>
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Represents a purchase order within the OrderList.
        /// </summary>
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }
    }
}
