namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// The error response schema for the `getFixedSlotCapacity` operation.
	/// </summary>
	public class FixedSlotCapacityErrors : BaseClass
	{
		/// <summary>
		/// Errors encountered during the `getFixedSlotCapacity` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
