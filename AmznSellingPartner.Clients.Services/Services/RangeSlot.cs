namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Capacity slots represented in a format similar to availability rules
	/// </summary>
	public class RangeSlot : BaseClass
	{
		/// <summary>
		/// Start date time of slot in ISO 8601 format with precision of seconds
		/// </summary>
		[JsonProperty("startDateTime")]
		public DateTime StartDateTime { get; set; }

		/// <summary>
		/// End date time of slot in ISO 8601 format with precision of seconds
		/// </summary>
		[JsonProperty("endDateTime")]
		public DateTime EndDateTime { get; set; }

		/// <summary>
		/// Capacity of the slot
		/// </summary>
		[JsonProperty("capacity")]
		public int Capacity { get; set; }
	}
}
