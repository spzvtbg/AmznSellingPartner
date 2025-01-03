namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Properties of packages
	/// </summary>
	public class PackageDetail : BaseClass
	{
		[IsRequired]
		[JsonProperty("packageReferenceId")]
		public PackageReferenceId PackageReferenceId { get; set; }

		/// <summary>
		/// Identifies the carrier that will deliver the package
		/// This field is required for all marketplaces
		/// For more information, refer to the [`CarrierCode` announcement](https://developer-docs
		/// amazon
		/// com/sp-api/changelog/carriercode-value-required-in-shipment-confirmations-for-br-mx-ca-sg-au-in-jp-marketplace
		/// )
		/// </summary>
		[IsRequired]
		[JsonProperty("carrierCode")]
		public string CarrierCode { get; set; }

		/// <summary>
		/// Carrier Name that will deliver the package
		/// Required when `carrierCode` is "Others"
		/// </summary>
		[JsonProperty("carrierName")]
		public string CarrierName { get; set; }

		/// <summary>
		/// Ship method to be used for shipping the order
		/// </summary>
		[JsonProperty("shippingMethod")]
		public string ShippingMethod { get; set; }

		/// <summary>
		/// The tracking number used to obtain tracking and delivery information
		/// </summary>
		[IsRequired]
		[JsonProperty("trackingNumber")]
		public string TrackingNumber { get; set; }

		/// <summary>
		/// The shipping date for the package
		/// Must be in <a href='https://developer-docs
		/// amazon
		/// com/sp-api/docs/iso-8601'>ISO 8601</a> date/time format
		/// </summary>
		[IsRequired]
		[JsonProperty("shipDate")]
		public DateTime ShipDate { get; set; }

		/// <summary>
		/// The unique identifier for the supply source
		/// </summary>
		[JsonProperty("shipFromSupplySourceId")]
		public string ShipFromSupplySourceId { get; set; }

		/// <summary>
		/// The list of order items and quantities to be updated
		/// </summary>
		[IsRequired]
		[JsonProperty("orderItems")]
		public ConfirmShipmentOrderItemsList OrderItems { get; set; }
	}
}
