namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// The time of the appointment window.
	/// </summary>
	public class AppointmentTime : BaseClass
	{
		/// <summary>
		/// The date and time of the start of the appointment window in ISO 8601 format.
		/// </summary>
		[JsonProperty("startTime")]
		[IsRequired]
		public DateTimeValue StartTime { get; set; } 

		/// <summary>
		/// The duration of the appointment window, in minutes.
		/// </summary>
		[JsonProperty("durationInMinutes")]
		[IsRequired]
		[Minimum(1)]
		public int DurationInMinutes { get; set; } 
	}
}
