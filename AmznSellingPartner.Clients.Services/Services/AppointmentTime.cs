namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

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
		public DateTime StartTime { get; set; }

		/// <summary>
		/// The duration of the appointment window, in minutes.
		/// </summary>
		[JsonProperty("durationInMinutes")]
		[IsRequired]
		[Minimum(1)]
		public int DurationInMinutes { get; set; }
	}
}
