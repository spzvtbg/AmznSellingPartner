namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Response schema for the `getRangeSlotCapacity` operation
	/// </summary>
	public class RangeSlotCapacity : BaseClass
	{
		/// <summary>
		/// Resource Identifier
		/// </summary>
		[JsonProperty("resourceId")]
		public string ResourceId { get; set; }

		/// <summary>
		/// Array of range capacities where each entry is for a specific capacity type
		/// </summary>
		[JsonProperty("capacities")]
		public List<RangeCapacity> Capacities { get; set; }

		/// <summary>
		/// Next page token, if there are more pages
		/// </summary>
		[JsonProperty("nextPageToken")]
		public string NextPageToken { get; set; }
	}
}
