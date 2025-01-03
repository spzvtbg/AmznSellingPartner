namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The origin for the delivery offer
	/// </summary>
	public class Origin : BaseClass
	{
		/// <summary>
		/// The two digit country code the items should ship from
		/// In ISO 3166-1 alpha-2 format
		/// </summary>
		[IsRequired]
		[MinLength(2)]
		[MaxLength(2)]
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }
	}
}
