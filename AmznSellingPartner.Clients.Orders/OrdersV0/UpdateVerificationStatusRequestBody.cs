namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The updated values of the `VerificationStatus` field.
	/// </summary>
	public class UpdateVerificationStatusRequestBody : BaseClass
	{
		/// <summary>
		/// The new verification status of the order.
		/// </summary>
		[JsonProperty("status")]
		public VerificationStatus Status { get; set; } 

		/// <summary>
		/// The identifier of the order's regulated information reviewer.
		/// </summary>
		[JsonProperty("externalReviewerId")]
		[IsRequired]
		public string ExternalReviewerId { get; set; } 

		/// <summary>
		/// The unique identifier of the rejection reason used for rejecting the order's regulated information.
		/// Only required if the new status is rejected.
		/// </summary>
		[JsonProperty("rejectionReasonId")]
		public string RejectionReasonId { get; set; } 

		/// <summary>
		/// Additional information regarding the verification of the order.
		/// </summary>
		[JsonProperty("verificationDetails")]
		public VerificationDetails VerificationDetails { get; set; } 
	}
}
