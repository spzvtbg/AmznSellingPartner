namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Preview of the changes that will be applied to the shipment.
	/// </summary>
	public class ContentUpdatePreview : BaseClass
	{
		/// <summary>
		/// Identifier of a content update preview.
		/// </summary>
		[JsonProperty("contentUpdatePreviewId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string ContentUpdatePreviewId { get; set; }

		/// <summary>
		/// The time at which the content update expires. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mm:ss.sssZ`.
		/// </summary>
		[JsonProperty("expiration")]
		[IsRequired]
		public DateTime Expiration { get; set; }

		[JsonProperty("requestedUpdates")]
		[IsRequired]
		public RequestedUpdates RequestedUpdates { get; set; }

		[JsonProperty("transportationOption")]
		[IsRequired]
		public TransportationOption TransportationOption { get; set; }
	}
}
