namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Address information for tracking the package.
	/// </summary>
	public class TrackingAddress : BaseClass
	{
		/// <summary>
		/// The city.
		/// </summary>
		[JsonProperty("city")]
		[IsRequired]
		[MaxLength(150)]
		public string City { get; set; }

		/// <summary>
		/// The state.
		/// </summary>
		[JsonProperty("state")]
		[IsRequired]
		[MaxLength(150)]
		public string State { get; set; }

		/// <summary>
		/// The country.
		/// </summary>
		[JsonProperty("country")]
		[IsRequired]
		[MaxLength(6)]
		public string Country { get; set; }
	}
}
