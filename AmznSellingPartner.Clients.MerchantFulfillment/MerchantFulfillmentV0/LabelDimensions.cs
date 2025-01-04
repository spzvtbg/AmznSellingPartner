namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Dimensions for printing a shipping label.
	/// </summary>
	public class LabelDimensions : BaseClass
	{
		/// <summary>
		/// The length dimension.
		/// </summary>
		[JsonProperty("Length")]
		[IsRequired]
		public LabelDimension Length { get; set; }

		/// <summary>
		/// The width dimension.
		/// </summary>
		[JsonProperty("Width")]
		[IsRequired]
		public LabelDimension Width { get; set; }

		/// <summary>
		/// The unit of measurement.
		/// </summary>
		[JsonProperty("Unit")]
		[IsRequired]
		public UnitOfLength Unit { get; set; }
	}
}
