namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// Response schema for the `cancelReservation` operation.
	/// </summary>
	public class CancelReservationResponse : BaseClass
	{
		/// <summary>
		/// Errors encountered, if any
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
