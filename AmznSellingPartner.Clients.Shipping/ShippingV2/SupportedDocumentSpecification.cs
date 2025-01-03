namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Document specification that is supported for a service offering.
	/// </summary>
	public class SupportedDocumentSpecification : BaseClass
	{
		[IsRequired]
		[JsonProperty("format")]
		public DocumentFormat Format { get; set; }

		[IsRequired]
		[JsonProperty("size")]
		public DocumentSize Size { get; set; }

		[IsRequired]
		[JsonProperty("printOptions")]
		public PrintOptionList PrintOptions { get; set; }
	}
}
