namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// An appointment slot time with start and end.
    /// </summary>
    public class AppointmentSlotTime : BaseClass
    {
        /// <summary>
        /// The end timestamp of the appointment in UTC.
        /// </summary>
        [JsonProperty("endTime")]
        [IsRequired]
        public DateTimeValue EndTime { get; set; }

        /// <summary>
        /// The start timestamp of the appointment in UTC.
        /// </summary>
        [JsonProperty("startTime")]
        [IsRequired]
        public DateTimeValue StartTime { get; set; }
    }
}
