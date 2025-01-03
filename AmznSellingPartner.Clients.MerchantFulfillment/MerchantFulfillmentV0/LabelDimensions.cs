namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Dimensions for printing a shipping label
	/// </summary>
	public class LabelDimensions : BaseClass
	{
		/// <summary>
		/// The length dimension
		/// </summary>
		[IsRequired]
		[JsonProperty("Length")]
		public LabelDimension Length { get; set; }

		/// <summary>
		/// The width dimension
		/// </summary>
		[IsRequired]
		[JsonProperty("Width")]
		public LabelDimension Width { get; set; }

		/// <summary>
		/// The unit of measurement
		/// </summary>
		[IsRequired]
		[JsonProperty("Unit")]
		public UnitOfLength Unit { get; set; }
	}
}
