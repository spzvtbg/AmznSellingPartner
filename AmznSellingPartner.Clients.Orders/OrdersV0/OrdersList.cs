namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A list of orders along with additional information to make subsequent API calls.
	/// </summary>
	public class OrdersList : BaseClass
	{
		[IsRequired]
		[JsonProperty("Orders")]
		public OrderList Orders { get; set; }

		/// <summary>
		/// When present and not empty, pass this string token in the next request to return the next response p
		/// age.
		/// </summary>
		[JsonProperty("NextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// Use this date to select orders that were last updated before (or at) a specified time. An update is defined
		/// as any change in order status, including the creation of a new order. Includes updates made by Amazon
		/// and by the seller. All dates must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// format.
		/// </summary>
		[JsonProperty("LastUpdatedBefore")]
		public string LastUpdatedBefore { get; set; }

		/// <summary>
		/// Use this date to select orders created before (or at) a specified time. Only orders placed before the
		/// specified time are returned. The date must be in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// format.
		/// </summary>
		[JsonProperty("CreatedBefore")]
		public string CreatedBefore { get; set; }
	}
}
