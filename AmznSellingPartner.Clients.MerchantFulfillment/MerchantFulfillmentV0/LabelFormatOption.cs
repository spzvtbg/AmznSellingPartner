namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The label format details and whether to include a packing slip
	/// </summary>
	public class LabelFormatOption : BaseClass
	{
		/// <summary>
		/// When true, include a packing slip with the label
		/// </summary>
		[JsonProperty("IncludePackingSlipWithLabel")]
		public bool IncludePackingSlipWithLabel { get; set; }

		[JsonProperty("LabelFormat")]
		public LabelFormat LabelFormat { get; set; }
	}
}
