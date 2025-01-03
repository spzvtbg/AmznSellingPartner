namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Data for creating a shipping label and dimensions for printing the label
	/// </summary>
	public class Label : BaseClass
	{
		[JsonProperty("CustomTextForLabel")]
		public CustomTextForLabel CustomTextForLabel { get; set; }

		[IsRequired]
		[JsonProperty("Dimensions")]
		public LabelDimensions Dimensions { get; set; }

		[IsRequired]
		[JsonProperty("FileContents")]
		public FileContents FileContents { get; set; }

		[JsonProperty("LabelFormat")]
		public LabelFormat LabelFormat { get; set; }

		[JsonProperty("StandardIdForLabel")]
		public StandardIdForLabel StandardIdForLabel { get; set; }
	}
}
