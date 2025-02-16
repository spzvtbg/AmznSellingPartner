namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Response  for the GetCollectionFormResponse operation.
    /// </summary>
    public class GetCollectionFormResponse : BaseClass
    {
        [JsonProperty("collectionsFormDocument")]
        public CollectionsFormDocument CollectionsFormDocument { get; set; }
    }
}
