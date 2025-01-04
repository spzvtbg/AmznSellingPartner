namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getMarketplaceParticipations` operation.
	/// </summary>
	public class GetMarketplaceParticipationsResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getMarketplaceParticipations` operation.
		/// </summary>
		[JsonProperty("payload")]
		public MarketplaceParticipationList Payload { get; set; } 

		/// <summary>
		/// A list of errors that occurred with the `getMarketplaceParticipations` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
