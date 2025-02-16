namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The request schema for the `submitShippingLabelRequest` operation.
    /// </summary>
    public class SubmitShippingLabelsRequest : BaseClass
    {
        /// <summary>
        /// An array of shipping label requests to be processed.
        /// </summary>
        [JsonProperty("shippingLabelRequests")]
        public List<ShippingLabelRequest> ShippingLabelRequests { get; set; }
    }
}
