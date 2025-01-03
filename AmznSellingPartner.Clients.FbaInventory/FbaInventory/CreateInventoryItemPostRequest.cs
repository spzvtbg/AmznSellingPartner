namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/fba/inventory/v1/items")]
	public class CreateInventoryItemPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// CreateInventoryItem Request Body Parameter.
		/// </summary>
		[InBody("createInventoryItemRequestBody")]
		[IsRequired]
		[JsonProperty("createInventoryItemRequestBody")]
		public CreateInventoryItemRequest CreateInventoryItemRequestBody { get; set; }
	}
}
