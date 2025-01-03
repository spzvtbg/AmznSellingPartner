namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// Total tax details for the line item.
	/// </summary>
	public class TaxItemDetails : BaseClass
	{
		/// <summary>
		/// Tax details.
		/// </summary>
		[JsonProperty("taxLineItem")]
		public TaxLineItem TaxLineItem { get; set; }
	}
}
