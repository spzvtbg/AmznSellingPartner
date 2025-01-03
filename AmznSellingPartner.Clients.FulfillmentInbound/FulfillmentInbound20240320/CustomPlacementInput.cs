namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Provide units going to the warehouse
	/// </summary>
	public class CustomPlacementInput : BaseClass
	{
		/// <summary>
		/// Items included while creating Inbound Plan
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(2000)]
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; }

		/// <summary>
		/// Warehouse Id
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("warehouseId")]
		public string WarehouseId { get; set; }
	}
}
