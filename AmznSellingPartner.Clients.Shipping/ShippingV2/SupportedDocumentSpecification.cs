namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Document specification that is supported for a service offering.
	/// </summary>
	public class SupportedDocumentSpecification : BaseClass
	{
		[JsonProperty("format")]
		[IsRequired]
		public DocumentFormat Format { get; set; }

		[JsonProperty("size")]
		[IsRequired]
		public DocumentSize Size { get; set; }

		[JsonProperty("printOptions")]
		[IsRequired]
		public PrintOptionList PrintOptions { get; set; }
	}
}
