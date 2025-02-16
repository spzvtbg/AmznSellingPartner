namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The fulfillment center appointment slot for the transportation option.
    /// </summary>
    public class AppointmentSlot : BaseClass
    {
        /// <summary>
        /// An identifier to a self-ship appointment slot.
        /// </summary>
        [JsonProperty("slotId")]
        [IsRequired]
        [Pattern("^[a-zA-Z0-9-]*")]
        [MinLength(38)]
        [MaxLength(38)]
        public string SlotId { get; set; }

        [JsonProperty("slotTime")]
        [IsRequired]
        public AppointmentSlotTime SlotTime { get; set; }
    }
}
