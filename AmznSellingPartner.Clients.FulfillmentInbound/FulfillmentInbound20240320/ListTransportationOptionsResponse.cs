namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The `listTransportationOptions` response.
    /// </summary>
    public class ListTransportationOptionsResponse : BaseClass
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Transportation options generated for the placement option.
        /// </summary>
        [JsonProperty("transportationOptions")]
        [IsRequired]
        public List<TransportationOption> TransportationOptions { get; set; }
    }
}
