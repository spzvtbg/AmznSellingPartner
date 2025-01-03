namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A product, marketplace, and proposed price used to request estimated fees
	/// </summary>
	public class FeesEstimateByIdRequest : BaseClass
	{
		[JsonProperty("FeesEstimateRequest")]
		public FeesEstimateRequest FeesEstimateRequest { get; set; }

		[IsRequired]
		[JsonProperty("IdType")]
		public IdType IdType { get; set; }

		/// <summary>
		/// The item identifier
		/// </summary>
		[IsRequired]
		[JsonProperty("IdValue")]
		public string IdValue { get; set; }
	}
}
