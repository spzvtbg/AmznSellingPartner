namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request body for the `updateShipmentStatus` operation
	/// </summary>
	public class UpdateShipmentStatusRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }

		[IsRequired]
		[JsonProperty("shipmentStatus")]
		public ShipmentStatus ShipmentStatus { get; set; }

		[JsonProperty("orderItems")]
		public OrderItems OrderItems { get; set; }
	}
}
