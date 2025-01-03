namespace AmznSellingPartner.Clients.VendorDirectFulfillmentSandboxTestData.VendorDirectFulfillmentSandboxData20211028
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Error response returned when the request is unsuccessful.
	/// </summary>
	public class TestOrder : BaseClass
	{
		/// <summary>
		/// An error code that identifies the type of error that occurred.
		/// </summary>
		[IsRequired]
		[JsonProperty("orderId")]
		public string OrderId { get; set; }
	}
}
