namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    using System.Runtime.Serialization;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponsibleParty
    {
        /// <summary>
        /// The `MarketplaceFacilitator` entity for the US marketplace.
        /// </summary>
        [EnumMember(Value = "Amazon Services, Inc.")]
        Amazon_Services__Inc_,
    }
}
