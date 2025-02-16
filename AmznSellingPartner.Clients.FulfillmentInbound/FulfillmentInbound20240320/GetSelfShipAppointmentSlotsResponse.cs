namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The `getSelfShipAppointmentSlots` response.
    /// </summary>
    public class GetSelfShipAppointmentSlotsResponse : BaseClass
    {
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("selfShipAppointmentSlotsAvailability")]
        [IsRequired]
        public SelfShipAppointmentSlotsAvailability SelfShipAppointmentSlotsAvailability { get; set; }
    }
}
