namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The verification status of the order, along with associated approval or rejection metadata.
	/// </summary>
	public class RegulatedOrderVerificationStatus : BaseClass
	{
		/// <summary>
		/// The verification status of the order.
		/// </summary>
		[IsRequired]
		[JsonProperty("Status")]
		public VerificationStatus Status { get; set; }

		/// <summary>
		/// When true, the regulated information provided in the order requires a review by the merchant.
		/// </summary>
		[IsRequired]
		[JsonProperty("RequiresMerchantAction")]
		public bool RequiresMerchantAction { get; set; }

		/// <summary>
		/// A list of valid rejection reasons that may be used to reject the order's regulated information.
		/// </summary>
		[IsRequired]
		[JsonProperty("ValidRejectionReasons")]
		public List<RejectionReason> ValidRejectionReasons { get; set; }

		/// <summary>
		/// The reason for rejecting the order's regulated information. Not present if the order isn't rejected.
		/// </summary>
		[JsonProperty("RejectionReason")]
		public RejectionReason RejectionReason { get; set; }

		/// <summary>
		/// The date the order was reviewed. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date time format.
		/// </summary>
		[JsonProperty("ReviewDate")]
		public string ReviewDate { get; set; }

		/// <summary>
		/// The identifier for the order's regulated information reviewer.
		/// </summary>
		[JsonProperty("ExternalReviewerId")]
		public string ExternalReviewerId { get; set; }

		/// <summary>
		/// A list of valid verification details that may be provided and the criteria required for when the verification
		/// detail can be provided.
		/// </summary>
		[JsonProperty("ValidVerificationDetails")]
		public List<ValidVerificationDetail> ValidVerificationDetails { get; set; }
	}
}
