namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request body for the `updateShipmentStatus` operation.
	/// </summary>
	public class UpdateShipmentStatusRequest : BaseClass
	{
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public MarketplaceId MarketplaceId { get; set; } 

		[JsonProperty("shipmentStatus")]
		[IsRequired]
		public ShipmentStatus ShipmentStatus { get; set; } 

		[JsonProperty("orderItems")]
		public OrderItems OrderItems { get; set; } 
	}
}
