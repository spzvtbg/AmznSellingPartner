namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Transport Request pickup date
	/// </summary>
	public class PurchaseOrders : BaseClass
	{
		/// <summary>
		/// Purchase order numbers involved in this shipment, list all the PO that are involved as part of this shipment.
		/// </summary>
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Purchase order numbers involved in this shipment, list all the PO that are involved as part of this shipment.
		/// </summary>
		[JsonProperty("purchaseOrderDate")]
		public DateTime PurchaseOrderDate { get; set; }

		/// <summary>
		/// Date range in which shipment is expected for these purchase orders.
		/// </summary>
		[JsonProperty("shipWindow")]
		public string ShipWindow { get; set; }

		/// <summary>
		/// A list of the items that are associated to the PO in this transport and their associated details.
		/// </summary>
		[JsonProperty("items")]
		public List<PurchaseOrderItems> Items { get; set; }
	}
}
