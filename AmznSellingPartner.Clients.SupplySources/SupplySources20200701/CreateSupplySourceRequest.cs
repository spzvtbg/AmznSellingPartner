namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A request to create a supply source.
    /// </summary>
    public class CreateSupplySourceRequest : BaseClass
    {
        [JsonProperty("supplySourceCode")]
        [IsRequired]
        public SupplySourceCode SupplySourceCode { get; set; }

        [JsonProperty("alias")]
        [IsRequired]
        public SupplySourceAlias Alias { get; set; }

        [JsonProperty("address")]
        [IsRequired]
        public Address Address { get; set; }
    }
}
