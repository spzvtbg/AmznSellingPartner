namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The supported document types for a service offering
	/// </summary>
	public class SupportedDocumentDetail : BaseClass
	{
		[IsRequired]
		[JsonProperty("name")]
		public DocumentType Name { get; set; }

		/// <summary>
		/// When true, the supported document type is required
		/// </summary>
		[IsRequired]
		[JsonProperty("isMandatory")]
		public bool IsMandatory { get; set; }
	}
}
