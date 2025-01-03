namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for an shipment confirmation
	/// </summary>
	public class ConfirmShipmentRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("packageDetail")]
		public PackageDetail PackageDetail { get; set; }

		/// <summary>
		/// The COD collection method (only supported in the JP marketplace)
		/// </summary>
		[JsonProperty("codCollectionMethod")]
		public CodCollectionMethod CodCollectionMethod { get; set; }

		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }
	}
}
