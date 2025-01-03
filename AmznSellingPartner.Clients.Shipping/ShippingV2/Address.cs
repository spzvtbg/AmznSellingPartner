namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The address
	/// </summary>
	public class Address : BaseClass
	{
		/// <summary>
		/// The name of the person, business or institution at the address
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(50)]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The first line of the address
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(60)]
		[JsonProperty("addressLine1")]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Additional address information, if required
		/// </summary>
		[MinLength(1)]
		[MaxLength(60)]
		[JsonProperty("addressLine2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// Additional address information, if required
		/// </summary>
		[MinLength(1)]
		[MaxLength(60)]
		[JsonProperty("addressLine3")]
		public string AddressLine3 { get; set; }

		/// <summary>
		/// The name of the business or institution associated with the address
		/// </summary>
		[JsonProperty("companyName")]
		public string CompanyName { get; set; }

		[IsRequired]
		[JsonProperty("stateOrRegion")]
		public StateOrRegion StateOrRegion { get; set; }

		[IsRequired]
		[JsonProperty("city")]
		public City City { get; set; }

		[IsRequired]
		[JsonProperty("countryCode")]
		public CountryCode CountryCode { get; set; }

		[IsRequired]
		[JsonProperty("postalCode")]
		public PostalCode PostalCode { get; set; }

		/// <summary>
		/// The email address of the contact associated with the address
		/// </summary>
		[MaxLength(64)]
		[JsonProperty("email")]
		public string Email { get; set; }

		/// <summary>
		/// The phone number of the person, business or institution located at that address, including the country calling
		/// code
		/// </summary>
		[MinLength(1)]
		[MaxLength(20)]
		[JsonProperty("phoneNumber")]
		public string PhoneNumber { get; set; }

		[JsonProperty("geocode")]
		public Geocode Geocode { get; set; }
	}
}
