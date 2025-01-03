namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The information required by a selling partner to issue a shipment invoice
	/// </summary>
	public class ShipmentDetail : BaseClass
	{
		/// <summary>
		/// The Amazon-defined identifier for the warehouse
		/// </summary>
		[JsonProperty("WarehouseId")]
		public string WarehouseId { get; set; }

		/// <summary>
		/// The Amazon-defined identifier for the order
		/// </summary>
		[JsonProperty("AmazonOrderId")]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// The Amazon-defined identifier for the shipment
		/// </summary>
		[JsonProperty("AmazonShipmentId")]
		public string AmazonShipmentId { get; set; }

		/// <summary>
		/// The date and time when the order was created
		/// </summary>
		[JsonProperty("PurchaseDate")]
		public DateTime PurchaseDate { get; set; }

		[JsonProperty("ShippingAddress")]
		public Address ShippingAddress { get; set; }

		[JsonProperty("PaymentMethodDetails")]
		public PaymentMethodDetailItemList PaymentMethodDetails { get; set; }

		/// <summary>
		/// The identifier for the marketplace where the order was placed
		/// </summary>
		[JsonProperty("MarketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The seller identifier
		/// </summary>
		[JsonProperty("SellerId")]
		public string SellerId { get; set; }

		/// <summary>
		/// The name of the buyer
		/// </summary>
		[JsonProperty("BuyerName")]
		public string BuyerName { get; set; }

		/// <summary>
		/// The county of the buyer
		/// </summary>
		[JsonProperty("BuyerCounty")]
		public string BuyerCounty { get; set; }

		[JsonProperty("BuyerTaxInfo")]
		public BuyerTaxInfo BuyerTaxInfo { get; set; }

		[JsonProperty("MarketplaceTaxInfo")]
		public MarketplaceTaxInfo MarketplaceTaxInfo { get; set; }

		/// <summary>
		/// The seller’s friendly name registered in the marketplace
		/// </summary>
		[JsonProperty("SellerDisplayName")]
		public string SellerDisplayName { get; set; }

		[JsonProperty("ShipmentItems")]
		public ShipmentItems ShipmentItems { get; set; }
	}
}
