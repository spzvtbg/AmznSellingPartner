namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    /// <summary>
    /// The error response schema for the `getRangeSlotCapacity` operation.
    /// </summary>
    public class RangeSlotCapacityErrors : BaseClass
    {
        /// <summary>
        /// Errors encountered during the `getRangeSlotCapacity` operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
