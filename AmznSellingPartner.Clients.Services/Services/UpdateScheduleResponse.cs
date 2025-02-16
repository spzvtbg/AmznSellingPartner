namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// Response schema for the `updateSchedule` operation.
    /// </summary>
    public class UpdateScheduleResponse : BaseClass
    {
        /// <summary>
        /// Contains the `UpdateScheduleRecords` for which the error/warning has occurred.
        /// </summary>
        [JsonProperty("payload")]
        public List<UpdateScheduleRecord> Payload { get; set; }

        /// <summary>
        /// Errors encountered, if any.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
