namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The order's regulated information along with its verification status.
	/// </summary>
	public class OrderRegulatedInfo : BaseClass
	{
		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format.
		/// </summary>
		[JsonProperty("AmazonOrderId")]
		[IsRequired]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// The regulated information collected during purchase and used to verify the order.
		/// </summary>
		[JsonProperty("RegulatedInformation")]
		[IsRequired]
		public RegulatedInformation RegulatedInformation { get; set; }

		/// <summary>
		/// When true, the order requires attaching a dosage information label when shipped.
		/// </summary>
		[JsonProperty("RequiresDosageLabel")]
		[IsRequired]
		public bool RequiresDosageLabel { get; set; }

		/// <summary>
		/// The order's verification status.
		/// </summary>
		[JsonProperty("RegulatedOrderVerificationStatus")]
		[IsRequired]
		public RegulatedOrderVerificationStatus RegulatedOrderVerificationStatus { get; set; }
	}
}
