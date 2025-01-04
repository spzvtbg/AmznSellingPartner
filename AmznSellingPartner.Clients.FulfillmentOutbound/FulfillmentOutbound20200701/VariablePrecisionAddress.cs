namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A physical address with varying degrees of precision. A more precise address can provide more accurate
	/// results than country code and postal code alone.
	/// </summary>
	public class VariablePrecisionAddress : BaseClass
	{
		/// <summary>
		/// The first line of the address.
		/// </summary>
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
		/// The city where the person, business, or institution is located. This property should not be used in
		/// Japan.
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
		[JsonProperty("stateOrRegion")]
		public string StateOrRegion { get; set; } 

		/// <summary>
		/// The postal code of the address.
		/// </summary>
		[JsonProperty("postalCode")]
		[IsRequired]
		public string PostalCode { get; set; } 

		/// <summary>
		/// The two digit country code. In ISO 3166-1 alpha-2 format.
		/// </summary>
		[JsonProperty("countryCode")]
		[IsRequired]
		[MinLength(2)]
		[MaxLength(2)]
		public string CountryCode { get; set; } 
	}
}
