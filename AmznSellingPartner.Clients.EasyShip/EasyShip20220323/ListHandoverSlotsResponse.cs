namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The response schema for the `listHandoverSlots` operation.
    /// </summary>
    public class ListHandoverSlotsResponse : BaseClass
    {
        [JsonProperty("amazonOrderId")]
        [IsRequired]
        public AmazonOrderId AmazonOrderId { get; set; }

        [JsonProperty("timeSlots")]
        [IsRequired]
        public TimeSlots TimeSlots { get; set; }
    }
}
