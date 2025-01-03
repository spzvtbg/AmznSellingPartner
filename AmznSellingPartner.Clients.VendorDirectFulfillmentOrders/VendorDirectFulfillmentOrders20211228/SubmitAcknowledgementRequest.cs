namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the submitAcknowledgement operation.
	/// </summary>
	public class SubmitAcknowledgementRequest : BaseClass
	{
		/// <summary>
		/// A list of one or more purchase orders.
		/// </summary>
		[JsonProperty("orderAcknowledgements")]
		public List<OrderAcknowledgementItem> OrderAcknowledgements { get; set; }
	}
}
