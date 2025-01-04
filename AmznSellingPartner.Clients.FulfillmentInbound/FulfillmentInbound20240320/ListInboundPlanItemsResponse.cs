namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `listInboundPlanItems` response.
	/// </summary>
	public class ListInboundPlanItemsResponse : BaseClass
	{
		/// <summary>
		/// The items in an inbound plan.
		/// </summary>
		[JsonProperty("items")]
		[IsRequired]
		public List<Item> Items { get; set; }

		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }
	}
}
