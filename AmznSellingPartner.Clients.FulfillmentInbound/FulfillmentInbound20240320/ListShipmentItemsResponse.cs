namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listShipmentItems` response.
	/// </summary>
	public class ListShipmentItemsResponse : BaseClass
	{
		/// <summary>
		/// The items in a shipment.
		/// </summary>
		[JsonProperty("items")]
		[IsRequired]
		public List<Item> Items { get; set; } 

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; } 
	}
}
