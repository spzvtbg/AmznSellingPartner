namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	public class OrderedQuantity : BaseClass
	{
		/// <summary>
		/// Item quantity ordered.
		/// </summary>
		[JsonProperty("orderedQuantityValue")]
		public ItemQuantity OrderedQuantityValue { get; set; }

		/// <summary>
		/// Details of item quantity ordered.
		/// </summary>
		[JsonProperty("orderedQuantityDetails")]
		public List<OrderedQuantityDetails> OrderedQuantityDetails { get; set; }
	}
}
