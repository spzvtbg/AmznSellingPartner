namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    /// <summary>
    /// `UpdateScheduleRecord` entity contains the `AvailabilityRecord` if there is an error/warning
    /// while performing the requested operation on it.
    /// </summary>
    public class UpdateScheduleRecord : BaseClass
    {
        /// <summary>
        /// Availability record if the operation failed.
        /// </summary>
        [JsonProperty("availability")]
        public AvailabilityRecord Availability { get; set; }

        /// <summary>
        /// Warnings encountered, if any.
        /// </summary>
        [JsonProperty("warnings")]
        public WarningList Warnings { get; set; }

        /// <summary>
        /// Errors encountered, if any.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
