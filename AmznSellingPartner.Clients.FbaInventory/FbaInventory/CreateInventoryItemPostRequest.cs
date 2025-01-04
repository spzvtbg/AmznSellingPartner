namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/fba/inventory/v1/items")]
	public class CreateInventoryItemPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// CreateInventoryItem Request Body Parameter.
		/// </summary>
		[InBody("createInventoryItemRequestBody")]
		[IsRequired]
		public CreateInventoryItemRequest CreateInventoryItemRequestBody { get; set; } 
	}
}
