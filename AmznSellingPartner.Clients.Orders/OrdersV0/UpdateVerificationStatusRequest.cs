namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request body for the `updateVerificationStatus` operation.
	/// </summary>
	public class UpdateVerificationStatusRequest : BaseClass
	{
		/// <summary>
		/// The updated values of the `VerificationStatus` field.
		/// </summary>
		[JsonProperty("regulatedOrderVerificationStatus")]
		[IsRequired]
		public UpdateVerificationStatusRequestBody RegulatedOrderVerificationStatus { get; set; } 
	}
}
