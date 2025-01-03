namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Buyer information.
	/// </summary>
	public class BuyerInfo : BaseClass
	{
		/// <summary>
		/// The anonymized email address of the buyer.
		/// </summary>
		[JsonProperty("BuyerEmail")]
		public string BuyerEmail { get; set; }

		/// <summary>
		/// The buyer name or the recipient name.
		/// </summary>
		[JsonProperty("BuyerName")]
		public string BuyerName { get; set; }

		/// <summary>
		/// The county of the buyer.  **Note**: This attribute is only available in the Brazil marketplace.
		/// </summary>
		[JsonProperty("BuyerCounty")]
		public string BuyerCounty { get; set; }

		/// <summary>
		/// Tax information about the buyer. Sellers can use this data to issue electronic invoices for business orders.
		/// *Note**: This attribute is only available for business orders in the Brazil, Mexico and India marketplaces.
		/// </summary>
		[JsonProperty("BuyerTaxInfo")]
		public BuyerTaxInfo BuyerTaxInfo { get; set; }

		/// <summary>
		/// The purchase order (PO) number entered by the buyer at checkout. Only returned for orders where the buyer ente
		/// ed a PO number at checkout.
		/// </summary>
		[JsonProperty("PurchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }
	}
}
