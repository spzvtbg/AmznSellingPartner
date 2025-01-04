namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// A time window along with associated capacity in which the service can be performed.
	/// </summary>
	public class AppointmentSlot : BaseClass
	{
		/// <summary>
		/// Time window start time in ISO 8601 format.
		/// </summary>
		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; } 

		/// <summary>
		/// Time window end time in ISO 8601 format.
		/// </summary>
		[JsonProperty("endTime")]
		public DateTime EndTime { get; set; } 

		/// <summary>
		/// Number of resources for which a slot can be reserved.
		/// </summary>
		[JsonProperty("capacity")]
		[Minimum(0)]
		public int Capacity { get; set; } 
	}
}
