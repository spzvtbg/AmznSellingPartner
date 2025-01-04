namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Input for rescheduled appointment operation.
	/// </summary>
	public class RescheduleAppointmentRequest : BaseClass
	{
		/// <summary>
		/// Input appointment time details.
		/// </summary>
		[JsonProperty("appointmentTime")]
		[IsRequired]
		public AppointmentTimeInput AppointmentTime { get; set; }

		/// <summary>
		/// Input appointment reschedule reason.
		/// </summary>
		[JsonProperty("rescheduleReasonCode")]
		[IsRequired]
		public RescheduleReasonCode RescheduleReasonCode { get; set; }
	}
}
