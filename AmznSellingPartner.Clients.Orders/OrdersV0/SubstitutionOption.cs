namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Substitution options for an order item
	/// </summary>
	public class SubstitutionOption : BaseClass
	{
		/// <summary>
		/// The item's Amazon Standard Identification Number (ASIN)
		/// </summary>
		[JsonProperty("ASIN")]
		public string ASIN { get; set; }

		/// <summary>
		/// The number of items to be picked for this substitution option
		/// 
		/// </summary>
		[JsonProperty("QuantityOrdered")]
		public int QuantityOrdered { get; set; }

		/// <summary>
		/// The item's seller stock keeping unit (SKU)
		/// </summary>
		[JsonProperty("SellerSKU")]
		public string SellerSKU { get; set; }

		/// <summary>
		/// The item's title
		/// </summary>
		[JsonProperty("Title")]
		public string Title { get; set; }

		/// <summary>
		/// Measurement information for the substitution option
		/// </summary>
		[JsonProperty("Measurement")]
		public Measurement Measurement { get; set; }
	}
}
