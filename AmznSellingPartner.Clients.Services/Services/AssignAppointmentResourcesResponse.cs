namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    /// <summary>
    /// Response schema for the `assignAppointmentResources` operation.
    /// </summary>
    public class AssignAppointmentResourcesResponse : BaseClass
    {
        /// <summary>
        /// The payload for the `assignAppointmentResource` operation.
        /// </summary>
        [JsonProperty("payload")]
        public Payload Payload { get; set; }

        /// <summary>
        /// Errors occurred during during the `assignAppointmentResources` operation.
        /// </summary>
        [JsonProperty("errors")]
        public ErrorList Errors { get; set; }
    }
}
