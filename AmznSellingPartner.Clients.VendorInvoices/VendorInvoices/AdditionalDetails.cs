namespace AmznSellingPartner.Clients.VendorInvoices.VendorInvoices
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Additional information provided by the selling party for tax-related or any other purpose
	/// </summary>
	public class AdditionalDetails : BaseClass
	{
		/// <summary>
		/// The type of the additional information provided by the selling party
		/// </summary>
		[IsRequired]
		[JsonProperty("type")]
		public Type Type { get; set; }

		/// <summary>
		/// The detail of the additional information provided by the selling party
		/// </summary>
		[IsRequired]
		[JsonProperty("detail")]
		public string Detail { get; set; }

		/// <summary>
		/// The language code of the additional information detail
		/// </summary>
		[JsonProperty("languageCode")]
		public string LanguageCode { get; set; }
	}
}
