namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Tax information about the marketplace
	/// </summary>
	public class MarketplaceTaxInfo : BaseClass
	{
		/// <summary>
		/// A list of tax classifications that apply to the order
		/// </summary>
		[JsonProperty("TaxClassifications")]
		public List<TaxClassification> TaxClassifications { get; set; }
	}
}
