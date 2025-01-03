namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The vendor procurement information for the listings item
	/// </summary>
	public class ItemProcurement : BaseClass
	{
		/// <summary>
		/// The price (numeric value) that you want Amazon to pay you for this product
		/// </summary>
		[IsRequired]
		[JsonProperty("costPrice")]
		public Money CostPrice { get; set; }
	}
}
