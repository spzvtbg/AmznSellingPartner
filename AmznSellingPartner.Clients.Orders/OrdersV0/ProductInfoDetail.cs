namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Product information on the number of items.
	/// </summary>
	public class ProductInfoDetail : BaseClass
	{
		/// <summary>
		/// The total number of items that are included in the ASIN.
		/// </summary>
		[JsonProperty("NumberOfItems")]
		public string NumberOfItems { get; set; } 
	}
}
