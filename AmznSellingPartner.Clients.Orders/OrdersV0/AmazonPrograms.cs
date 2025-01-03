namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains the list of programs that are associated with an item.  Possible programs are:  - **Subscribe
	/// and Save**: Offers recurring, scheduled deliveries to Amazon customers and Amazon Business customers
	/// for their frequently ordered products.
	/// </summary>
	public class AmazonPrograms : BaseClass
	{
		/// <summary>
		/// A list of the programs that are associated with the specified order item.  **Possible values**: `SUB
		/// SCRIBE_AND_SAVE`
		/// </summary>
		[IsRequired]
		[JsonProperty("Programs")]
		public List<string> Programs { get; set; }
	}
}
