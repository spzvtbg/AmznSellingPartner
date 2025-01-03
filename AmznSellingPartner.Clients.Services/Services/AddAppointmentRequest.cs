namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Input for add appointment operation.
	/// </summary>
	public class AddAppointmentRequest : BaseClass
	{
		/// <summary>
		/// Input appointment time details.
		/// </summary>
		[IsRequired]
		[JsonProperty("appointmentTime")]
		public AppointmentTimeInput AppointmentTime { get; set; }
	}
}
