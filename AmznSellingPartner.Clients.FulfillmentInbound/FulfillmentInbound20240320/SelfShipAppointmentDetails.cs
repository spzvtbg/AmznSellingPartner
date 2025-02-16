namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Appointment details for carrier pickup or fulfillment center appointments.
    /// </summary>
    public class SelfShipAppointmentDetails : BaseClass
    {
        /// <summary>
        /// Identifier for appointment.
        /// </summary>
        [JsonProperty("appointmentId")]
        public double AppointmentId { get; set; }

        [JsonProperty("appointmentSlotTime")]
        public AppointmentSlotTime AppointmentSlotTime { get; set; }

        /// <summary>
        /// Status of the appointment.
        /// </summary>
        [JsonProperty("appointmentStatus")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string AppointmentStatus { get; set; }
    }
}
