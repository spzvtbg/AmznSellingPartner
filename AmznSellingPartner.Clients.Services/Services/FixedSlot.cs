namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// In this slot format each slot only has the requested capacity types. This slot size is as specified
    /// by slot duration.
    /// </summary>
    public class FixedSlot : BaseClass
    {
        /// <summary>
        /// Start date time of slot in ISO 8601 format with precision of seconds.
        /// </summary>
        [JsonProperty("startDateTime")]
        public DateTimeValue StartDateTime { get; set; }

        /// <summary>
        /// Scheduled capacity corresponding to the slot. This capacity represents the originally allocated
        /// capacity as per resource schedule.
        /// </summary>
        [JsonProperty("scheduledCapacity")]
        public int ScheduledCapacity { get; set; }

        /// <summary>
        /// Available capacity corresponding to the slot. This capacity represents the capacity available
        /// for allocation to reservations.
        /// </summary>
        [JsonProperty("availableCapacity")]
        public int AvailableCapacity { get; set; }

        /// <summary>
        /// Encumbered capacity corresponding to the slot. This capacity represents the capacity allocated
        /// for Amazon Jobs/Appointments/Orders.
        /// </summary>
        [JsonProperty("encumberedCapacity")]
        public int EncumberedCapacity { get; set; }

        /// <summary>
        /// Reserved capacity corresponding to the slot. This capacity represents the capacity made unavailable
        /// due to events like Breaks/Leaves/Lunch.
        /// </summary>
        [JsonProperty("reservedCapacity")]
        public int ReservedCapacity { get; set; }
    }
}
