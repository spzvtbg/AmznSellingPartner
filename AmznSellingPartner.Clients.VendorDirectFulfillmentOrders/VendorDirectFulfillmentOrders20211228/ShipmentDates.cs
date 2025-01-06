namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Shipment dates.
	/// </summary>
	public class ShipmentDates : BaseClass
	{
		/// <summary>
		/// Time by which the vendor is required to ship the order.
		/// </summary>
		[JsonProperty("requiredShipDate")]
		[IsRequired]
		public DateTimeValue RequiredShipDate { get; set; } 

		/// <summary>
		/// Delivery date promised to the Amazon customer.
		/// </summary>
		[JsonProperty("promisedDeliveryDate")]
		public DateTimeValue PromisedDeliveryDate { get; set; } 
	}
}
