namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listPackingGroupItems` response
	/// </summary>
	public class ListPackingGroupItemsResponse : BaseClass
	{
		/// <summary>
		/// Provides the information about the list of items in the packing group
		/// </summary>
		[IsRequired]
		[JsonProperty("items")]
		public List<Item> Items { get; set; }

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
