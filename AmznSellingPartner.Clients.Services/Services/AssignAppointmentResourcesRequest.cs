namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Request schema for the `assignAppointmentResources` operation.
    /// </summary>
    public class AssignAppointmentResourcesRequest : BaseClass
    {
        /// <summary>
        /// List of resource objects to be assigned.
        /// </summary>
        [JsonProperty("resources")]
        [IsRequired]
        public AppointmentResources Resources { get; set; }
    }
}
