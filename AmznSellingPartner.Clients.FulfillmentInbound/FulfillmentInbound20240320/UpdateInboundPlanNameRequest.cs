namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The `updateInboundPlanName` request.
    /// </summary>
    public class UpdateInboundPlanNameRequest : BaseClass
    {
        /// <summary>
        /// A human-readable name to update the inbound plan name to.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name { get; set; }
    }
}
