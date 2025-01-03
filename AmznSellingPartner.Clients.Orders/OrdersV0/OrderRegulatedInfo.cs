namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The order's regulated information along with its verification status
	/// </summary>
	public class OrderRegulatedInfo : BaseClass
	{
		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format
		/// </summary>
		[IsRequired]
		[JsonProperty("AmazonOrderId")]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// The regulated information collected during purchase and used to verify the order
		/// </summary>
		[IsRequired]
		[JsonProperty("RegulatedInformation")]
		public RegulatedInformation RegulatedInformation { get; set; }

		/// <summary>
		/// When true, the order requires attaching a dosage information label when shipped
		/// </summary>
		[IsRequired]
		[JsonProperty("RequiresDosageLabel")]
		public bool RequiresDosageLabel { get; set; }

		/// <summary>
		/// The order's verification status
		/// </summary>
		[IsRequired]
		[JsonProperty("RegulatedOrderVerificationStatus")]
		public RegulatedOrderVerificationStatus RegulatedOrderVerificationStatus { get; set; }
	}
}
