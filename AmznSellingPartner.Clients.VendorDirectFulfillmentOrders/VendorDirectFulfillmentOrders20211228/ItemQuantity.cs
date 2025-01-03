namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// Details of quantity ordered.
	/// </summary>
	public class ItemQuantity : BaseClass
	{
		/// <summary>
		/// Acknowledged quantity. This value should not be zero.
		/// </summary>
		[JsonProperty("amount")]
		public int Amount { get; set; }

		/// <summary>
		/// Unit of measure for the acknowledged quantity.
		/// </summary>
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }
	}
}
