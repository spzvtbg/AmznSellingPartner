namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The order items list along with the order ID.
	/// </summary>
	public class OrderItemsList : BaseClass
	{
		[IsRequired]
		[JsonProperty("OrderItems")]
		public OrderItemList OrderItems { get; set; }

		/// <summary>
		/// When present and not empty, pass this string token in the next request to return the next response p
		/// age.
		/// </summary>
		[JsonProperty("NextToken")]
		public string NextToken { get; set; }

		/// <summary>
		/// An Amazon-defined order identifier, in 3-7-7 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("AmazonOrderId")]
		public string AmazonOrderId { get; set; }
	}
}
