namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The document specifications requested. For calls to the purchaseShipment operation, the shipment purchase fail
	/// if the specified document specifications are not among those returned in the response to the getRates operati
	/// n.
	/// </summary>
	public class RequestedDocumentSpecification : BaseClass
	{
		[IsRequired]
		[JsonProperty("format")]
		public DocumentFormat Format { get; set; }

		[IsRequired]
		[JsonProperty("size")]
		public DocumentSize Size { get; set; }

		[JsonProperty("dpi")]
		public Dpi Dpi { get; set; }

		[JsonProperty("pageLayout")]
		public PageLayout PageLayout { get; set; }

		[IsRequired]
		[JsonProperty("needFileJoining")]
		public NeedFileJoining NeedFileJoining { get; set; }

		/// <summary>
		/// A list of the document types requested.
		/// </summary>
		[IsRequired]
		[JsonProperty("requestedDocumentTypes")]
		public List<DocumentType> RequestedDocumentTypes { get; set; }
	}
}
