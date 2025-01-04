namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getAccount` operation.
	/// </summary>
	public class GetAccountResponse : BaseClass
	{
		[JsonProperty("payload")]
		public Account Payload { get; set; } 

		/// <summary>
		/// A list of errors that occurred with the `getAccount` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
