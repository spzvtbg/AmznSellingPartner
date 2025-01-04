namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The supported document types for a service offering.
	/// </summary>
	public class SupportedDocumentDetail : BaseClass
	{
		[JsonProperty("name")]
		[IsRequired]
		public DocumentType Name { get; set; }

		/// <summary>
		/// When true, the supported document type is required.
		/// </summary>
		[JsonProperty("isMandatory")]
		[IsRequired]
		public bool IsMandatory { get; set; }
	}
}
