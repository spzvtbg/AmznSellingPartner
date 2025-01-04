namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;

	/// <summary>
	/// Buyer segment or program this offer is applicable to.
	/// </summary>
	public class Audience : BaseClass
	{
		/// <summary>
		/// Name of the audience an offer is applicable to.   Common values:   * 'ALL' - Standard offer audience
		/// for buyers on Amazon retail websites.   * 'B2B' - Offer audience for Amazon Business website buyers.
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; } 

		/// <summary>
		/// Localized display name for the audience.
		/// </summary>
		[JsonProperty("displayName")]
		public string DisplayName { get; set; } 
	}
}
