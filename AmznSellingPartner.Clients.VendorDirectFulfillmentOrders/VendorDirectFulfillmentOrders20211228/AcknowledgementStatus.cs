namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using Newtonsoft.Json;

	/// <summary>
	/// Status of acknowledgement
	/// </summary>
	public class AcknowledgementStatus : BaseClass
	{
		/// <summary>
		/// Acknowledgement code is a unique two digit value which indicates the status of the acknowledgement
		/// For a list of acknowledgement codes that Amazon supports, see the Vendor Direct Fulfillment APIs Use Case Gui
		/// e
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// Reason for the acknowledgement code
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
