namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The error response schema for the `UpdateVerificationStatus` operation
	/// </summary>
	public class UpdateVerificationStatusErrorResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `UpdateVerificationStatus` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
