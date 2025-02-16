namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Use these parameters to sort the response.
    /// </summary>
    public class ListOffersRequestSort : BaseClass
    {
        /// <summary>
        /// The sort order.
        /// </summary>
        [JsonProperty("order")]
        [IsRequired]
        public SortOrder Order { get; set; }

        /// <summary>
        /// The attribute to use to sort the results.
        /// </summary>
        [JsonProperty("key")]
        [IsRequired]
        public ListOffersSortKey Key { get; set; }
    }
}
