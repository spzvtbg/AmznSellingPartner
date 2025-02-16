namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Input for add appointment operation.
    /// </summary>
    public class AddAppointmentRequest : BaseClass
    {
        /// <summary>
        /// Input appointment time details.
        /// </summary>
        [JsonProperty("appointmentTime")]
        [IsRequired]
        public AppointmentTimeInput AppointmentTime { get; set; }
    }
}
