namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// `AvailabilityRecord` to represent the capacity of a resource over a time range.
	/// </summary>
	public class AvailabilityRecord : BaseClass
	{
		/// <summary>
		/// Denotes the time from when the resource is available in a day in ISO-8601 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// Denotes the time till when the resource is available in a day in ISO-8601 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("endTime")]
		public DateTime EndTime { get; set; }

		/// <summary>
		/// Recurrence object containing the recurrence pattern of schedule.
		/// </summary>
		[JsonProperty("recurrence")]
		public Recurrence Recurrence { get; set; }

		/// <summary>
		/// Signifies the capacity of a resource which is available.
		/// </summary>
		[Minimum(1)]
		[JsonProperty("capacity")]
		public int Capacity { get; set; }
	}
}
