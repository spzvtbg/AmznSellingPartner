namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The request for the listAllFulfillmentOrders operation.
    /// </summary>
    public class ListAllFulfillmentOrdersResult : BaseClass
    {
        /// <summary>
        /// When present and not empty, pass this string token in the next request to return the next response
        /// page.
        /// </summary>
        [JsonProperty("nextToken")]
        public string NextToken { get; set; }

        /// <summary>
        /// An array of fulfillment order information.
        /// </summary>
        [JsonProperty("fulfillmentOrders")]
        public List<FulfillmentOrder> FulfillmentOrders { get; set; }
    }
}
