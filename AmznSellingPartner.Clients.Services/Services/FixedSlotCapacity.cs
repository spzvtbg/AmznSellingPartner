namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Response schema for the `getFixedSlotCapacity` operation.
	/// </summary>
	public class FixedSlotCapacity : BaseClass
	{
		/// <summary>
		/// Resource Identifier.
		/// </summary>
		[JsonProperty("resourceId")]
		public string ResourceId { get; set; }

		/// <summary>
		/// The duration of each slot which is returned. This value will be a multiple of 5 and fall in the following rang
		/// : 5 <= `slotDuration` <= 360.
		/// </summary>
		[JsonProperty("slotDuration")]
		public int SlotDuration { get; set; }

		/// <summary>
		/// Array of capacity slots in fixed slot format.
		/// </summary>
		[JsonProperty("capacities")]
		public List<FixedSlot> Capacities { get; set; }

		/// <summary>
		/// Next page token, if there are more pages.
		/// </summary>
		[JsonProperty("nextPageToken")]
		public string NextPageToken { get; set; }
	}
}
