namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The reason for rejecting the order's regulated information. This is only present if the order
	/// is rejected.
	/// </summary>
	public class RejectionReason : BaseClass
	{
		/// <summary>
		/// The unique identifier for the rejection reason.
		/// </summary>
		[JsonProperty("RejectionReasonId")]
		[IsRequired]
		public string RejectionReasonId { get; set; } 

		/// <summary>
		/// The description of this rejection reason.
		/// </summary>
		[JsonProperty("RejectionReasonDescription")]
		[IsRequired]
		public string RejectionReasonDescription { get; set; } 
	}
}
