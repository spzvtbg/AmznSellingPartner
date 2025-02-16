namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// The response schema for the `listOffers` operation.
    /// </summary>
    public class ListOffersResponse : BaseClass
    {
        /// <summary>
        /// A list of offers.
        /// </summary>
        [JsonProperty("offers")]
        public List<ListOffersResponseOffer> Offers { get; set; }

        /// <summary>
        /// Use these parameters to paginate through the response.
        /// </summary>
        [JsonProperty("pagination")]
        public PaginationResponse Pagination { get; set; }
    }
}
