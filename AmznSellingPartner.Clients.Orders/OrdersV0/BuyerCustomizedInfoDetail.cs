namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Buyer information for custom orders from the Amazon Custom program.
	/// </summary>
	public class BuyerCustomizedInfoDetail : BaseClass
	{
		/// <summary>
		/// The location of a ZIP file containing Amazon Custom data.
		/// </summary>
		[JsonProperty("CustomizedURL")]
		public string CustomizedURL { get; set; }
	}
}
