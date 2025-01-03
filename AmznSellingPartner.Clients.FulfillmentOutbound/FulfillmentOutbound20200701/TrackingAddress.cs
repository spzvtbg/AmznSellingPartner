namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Address information for tracking the package
	/// </summary>
	public class TrackingAddress : BaseClass
	{
		/// <summary>
		/// The city
		/// </summary>
		[IsRequired]
		[MaxLength(150)]
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		/// The state
		/// </summary>
		[IsRequired]
		[MaxLength(150)]
		[JsonProperty("state")]
		public string State { get; set; }

		/// <summary>
		/// The country
		/// </summary>
		[IsRequired]
		[MaxLength(6)]
		[JsonProperty("country")]
		public string Country { get; set; }
	}
}
