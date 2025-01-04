namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `ListShipmentContentUpdatePreviews` response.
	/// </summary>
	public class ListShipmentContentUpdatePreviewsResponse : BaseClass
	{
		/// <summary>
		/// A list of content update previews in a shipment.
		/// </summary>
		[JsonProperty("contentUpdatePreviews")]
		[IsRequired]
		public List<ContentUpdatePreview> ContentUpdatePreviews { get; set; } 

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; } 
	}
}
