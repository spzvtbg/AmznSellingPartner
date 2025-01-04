namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The input appointment time details.
	/// </summary>
	public class AppointmentTimeInput : BaseClass
	{
		/// <summary>
		/// The date, time in UTC for the start time of an appointment in ISO 8601 format.
		/// </summary>
		[JsonProperty("startTime")]
		[IsRequired]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// The duration of an appointment in minutes.
		/// </summary>
		[JsonProperty("durationInMinutes")]
		public int DurationInMinutes { get; set; }
	}
}
