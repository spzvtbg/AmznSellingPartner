namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    /// <summary>
    /// Input for set appointment fulfillment data operation.
    /// </summary>
    public class SetAppointmentFulfillmentDataRequest : BaseClass
    {
        /// <summary>
        /// Input appointment time details.
        /// </summary>
        [JsonProperty("fulfillmentTime")]
        public FulfillmentTime FulfillmentTime { get; set; }

        /// <summary>
        /// Resources involved in appointment fulfillment.
        /// </summary>
        [JsonProperty("appointmentResources")]
        public AppointmentResources AppointmentResources { get; set; }

        /// <summary>
        /// Documents specific to appointment fulfillment.
        /// </summary>
        [JsonProperty("fulfillmentDocuments")]
        public FulfillmentDocuments FulfillmentDocuments { get; set; }
    }
}
