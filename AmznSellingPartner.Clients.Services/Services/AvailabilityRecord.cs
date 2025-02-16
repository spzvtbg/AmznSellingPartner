namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// `AvailabilityRecord` to represent the capacity of a resource over a time range.
    /// </summary>
    public class AvailabilityRecord : BaseClass
    {
        /// <summary>
        /// Denotes the time from when the resource is available in a day in ISO-8601 format.
        /// </summary>
        [JsonProperty("startTime")]
        [IsRequired]
        public DateTimeValue StartTime { get; set; }

        /// <summary>
        /// Denotes the time till when the resource is available in a day in ISO-8601 format.
        /// </summary>
        [JsonProperty("endTime")]
        [IsRequired]
        public DateTimeValue EndTime { get; set; }

        /// <summary>
        /// Recurrence object containing the recurrence pattern of schedule.
        /// </summary>
        [JsonProperty("recurrence")]
        public Recurrence Recurrence { get; set; }

        /// <summary>
        /// Signifies the capacity of a resource which is available.
        /// </summary>
        [JsonProperty("capacity")]
        [Minimum(1)]
        public int Capacity { get; set; }
    }
}
