namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The tax classification of the order.
	/// </summary>
	public class TaxClassification : BaseClass
	{
		/// <summary>
		/// The type of tax.
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get; set; }

		/// <summary>
		/// The buyer's tax identifier.
		/// </summary>
		[JsonProperty("Value")]
		public string Value { get; set; }
	}
}
