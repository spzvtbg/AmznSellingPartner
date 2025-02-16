namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// A list of packing slips.
    /// </summary>
    public class PackingSlipList : BaseClass
    {
        /// <summary>
        /// The pagination elements required to retrieve the remaining data.
        /// </summary>
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// An array of packing slip objects.
        /// </summary>
        [JsonProperty("packingSlips")]
        public List<PackingSlip> PackingSlips { get; set; }
    }
}
