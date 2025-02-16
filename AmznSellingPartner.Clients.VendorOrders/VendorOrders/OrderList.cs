namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of orders returned as response.
    /// </summary>
    public class OrderList : BaseClass
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Represents an individual order within the OrderList.
        /// </summary>
        [JsonProperty("orders")]
        public List<Order> Orders { get; set; }
    }
}
