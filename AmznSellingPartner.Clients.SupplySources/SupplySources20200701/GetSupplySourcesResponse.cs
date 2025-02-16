namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using Newtonsoft.Json;

    /// <summary>
    /// The paginated list of supply sources.
    /// </summary>
    public class GetSupplySourcesResponse : BaseClass
    {
        [JsonProperty("supplySources")]
        public SupplySourceList SupplySources { get; set; }

        /// <summary>
        /// If present, use this pagination token to retrieve the next page of supply sources.
        /// </summary>
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }
    }
}
