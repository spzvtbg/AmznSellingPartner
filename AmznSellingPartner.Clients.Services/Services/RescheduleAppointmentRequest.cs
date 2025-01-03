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
		[IsRequired]
		[JsonProperty("appointmentTime")]
		public AppointmentTimeInput AppointmentTime { get; set; }

		/// <summary>
		/// Input appointment reschedule reason.
		/// </summary>
		[IsRequired]
		[JsonProperty("rescheduleReasonCode")]
		public RescheduleReasonCode RescheduleReasonCode { get; set; }
	}
}
