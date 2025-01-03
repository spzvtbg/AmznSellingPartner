namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The time of the appointment window
	/// </summary>
	public class AppointmentTime : BaseClass
	{
		/// <summary>
		/// The date and time of the start of the appointment window in ISO 8601 format
		/// </summary>
		[IsRequired]
		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// The duration of the appointment window, in minutes
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[JsonProperty("durationInMinutes")]
		public int DurationInMinutes { get; set; }
	}
}
