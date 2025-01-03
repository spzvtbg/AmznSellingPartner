namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Consists of the order preference and corresponding preference value
	/// </summary>
	public class OrderAttribute : BaseClass
	{
		/// <summary>
		/// Preference for the distribution order
		/// </summary>
		[IsRequired]
		[JsonProperty("orderPreference")]
		public OrderPreference OrderPreference { get; set; }

		/// <summary>
		/// Value for the order preference
		/// </summary>
		[IsRequired]
		[JsonProperty("orderPreferenceValue")]
		public OrderPreferenceValue OrderPreferenceValue { get; set; }
	}
}
