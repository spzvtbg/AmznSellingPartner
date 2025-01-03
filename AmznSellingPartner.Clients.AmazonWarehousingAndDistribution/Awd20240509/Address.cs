namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Shipping address that represents the origin or destination location.
	/// </summary>
	public class Address : BaseClass
	{
		/// <summary>
		/// First line of the address text.
		/// </summary>
		[IsRequired]
		[JsonProperty("addressLine1")]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Optional second line of the address text.
		/// </summary>
		[JsonProperty("addressLine2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// Optional third line of the address text.
		/// </summary>
		[JsonProperty("addressLine3")]
		public string AddressLine3 { get; set; }

		/// <summary>
		/// Optional city where this address is located.
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		/// Two-digit, ISO 3166-1 alpha-2 formatted country code where this address is located.
		/// </summary>
		[IsRequired]
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		/// <summary>
		/// Optional county where this address is located.
		/// </summary>
		[JsonProperty("county")]
		public string County { get; set; }

		/// <summary>
		/// Optional district where this address is located.
		/// </summary>
		[JsonProperty("district")]
		public string District { get; set; }

		/// <summary>
		/// Name of the person, business, or institution at this address.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Optional E.164-formatted phone number for an available contact at this address.
		/// </summary>
		[JsonProperty("phoneNumber")]
		public string PhoneNumber { get; set; }

		/// <summary>
		/// Optional postal code where this address is located.
		/// </summary>
		[JsonProperty("postalCode")]
		public string PostalCode { get; set; }

		/// <summary>
		/// State or region where this address is located. Note that this is contextual to the specified country code.
		/// </summary>
		[IsRequired]
		[JsonProperty("stateOrRegion")]
		public string StateOrRegion { get; set; }
	}
}
