namespace AmznSellingPartner.Clients.VendorDirectFulfillmentInventory.VendorDirectFulfillmentInventoryV1
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/vendor/directFulfillment/inventory/v1/warehouses/{warehouseId}/items")]
	public class SubmitInventoryUpdatePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request body containing the inventory update data to submit
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public SubmitInventoryUpdateRequest Body { get; set; }

		/// <summary>
		/// Identifier for the warehouse for which to update inventory
		/// </summary>
		[InPath("warehouseId")]
		[IsRequired]
		[JsonProperty("warehouseId")]
		public string WarehouseId { get; set; }
	}
}
