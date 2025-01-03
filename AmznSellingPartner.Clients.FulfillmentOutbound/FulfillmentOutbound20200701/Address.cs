namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A physical address.
	/// </summary>
	public class Address : BaseClass
	{
		/// <summary>
		/// The name of the person, business or institution at the address.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The first line of the address.
		/// </summary>
		[IsRequired]
		[JsonProperty("addressLine1")]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Additional address information, if required.
		/// </summary>
		[JsonProperty("addressLine2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// Additional address information, if required.
		/// </summary>
		[JsonProperty("addressLine3")]
		public string AddressLine3 { get; set; }

		/// <summary>
		/// The city where the person, business, or institution is located. This property is required in all countries
		/// except Japan. It should not be used in Japan.
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		/// The district or county where the person, business, or institution is located.
		/// </summary>
		[JsonProperty("districtOrCounty")]
		public string DistrictOrCounty { get; set; }

		/// <summary>
		/// The state or region where the person, business or institution is located.
		/// </summary>
		[IsRequired]
		[JsonProperty("stateOrRegion")]
		public string StateOrRegion { get; set; }

		/// <summary>
		/// The postal code of the address.
		/// </summary>
		[IsRequired]
		[JsonProperty("postalCode")]
		public string PostalCode { get; set; }

		/// <summary>
		/// The two digit country code. In ISO 3166-1 alpha-2 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		/// <summary>
		/// The phone number of the person, business, or institution located at the address.
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; }
	}
}
