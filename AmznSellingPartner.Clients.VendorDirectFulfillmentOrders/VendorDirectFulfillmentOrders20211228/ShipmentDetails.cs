namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Shipment details required for the shipment.
	/// </summary>
	public class ShipmentDetails : BaseClass
	{
		/// <summary>
		/// When true, this is a priority shipment.
		/// </summary>
		[JsonProperty("isPriorityShipment")]
		[IsRequired]
		public bool IsPriorityShipment { get; set; } 

		/// <summary>
		/// When true, this order is part of a scheduled delivery program.
		/// </summary>
		[JsonProperty("isScheduledDeliveryShipment")]
		public bool IsScheduledDeliveryShipment { get; set; } 

		/// <summary>
		/// When true, a packing slip is required to be sent to the customer.
		/// </summary>
		[JsonProperty("isPslipRequired")]
		[IsRequired]
		public bool IsPslipRequired { get; set; } 

		/// <summary>
		/// When true, the order contain a gift. Include the gift message and gift wrap information.
		/// </summary>
		[JsonProperty("isGift")]
		public bool IsGift { get; set; } 

		/// <summary>
		/// Ship method to be used for shipping the order. Amazon defines ship method codes indicating the shipping
		/// carrier and shipment service level. To see the full list of ship methods in use, including both the code
		/// and the friendly name, search the 'Help' section on Vendor Central for 'ship methods'.
		/// </summary>
		[JsonProperty("shipMethod")]
		[IsRequired]
		public string ShipMethod { get; set; } 

		[JsonProperty("shipmentDates")]
		[IsRequired]
		public ShipmentDates ShipmentDates { get; set; } 

		/// <summary>
		/// Message to customer for order status.
		/// </summary>
		[JsonProperty("messageToCustomer")]
		[IsRequired]
		public string MessageToCustomer { get; set; } 
	}
}
