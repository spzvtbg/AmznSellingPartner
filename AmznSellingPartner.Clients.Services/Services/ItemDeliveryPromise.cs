namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Promised delivery information for the item
	/// </summary>
	public class ItemDeliveryPromise : BaseClass
	{
		/// <summary>
		/// The date and time of the start of the promised delivery window in ISO 8601 format
		/// </summary>
		[JsonProperty("startTime")]
		public DateTime StartTime { get; set; }

		/// <summary>
		/// The date and time of the end of the promised delivery window in ISO 8601 format
		/// </summary>
		[JsonProperty("endTime")]
		public DateTime EndTime { get; set; }
	}
}
