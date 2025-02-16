namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    /// <summary>
    /// Response schema for the `cancelServiceJobByServiceJobId` operation.
    /// </summary>
    public class CancelServiceJobByServiceJobIdResponse : BaseClass
    {
        /// <summary>
        /// Encountered errors for the `cancelServiceJobByServiceJobId` operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
