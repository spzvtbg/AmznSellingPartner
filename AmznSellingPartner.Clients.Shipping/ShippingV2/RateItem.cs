namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Rate Item for shipping (base cost, transaction fee, confirmation, insurance, etc.) Data source definition:
	/// 
	/// </summary>
	public class RateItem : BaseClass
	{
		[JsonProperty("rateItemID")]
		public RateItemID RateItemID { get; set; }

		[JsonProperty("rateItemType")]
		public RateItemType RateItemType { get; set; }

		[JsonProperty("rateItemCharge")]
		public Currency RateItemCharge { get; set; }

		/// <summary>
		/// Used for the localization.
		/// </summary>
		[JsonProperty("rateItemNameLocalization")]
		public string RateItemNameLocalization { get; set; }
	}
}
