namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Address of the party.
	/// </summary>
	public class Address : BaseClass
	{
		/// <summary>
		/// The name of the person, business or institution at that address. For Amazon label only vendors, this field wil
		/// have the value `xxxxx` within the object `shipToParty`.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The attention name of the person at that address. For Amazon label only vendors, this field will have the valu
		/// `xxxxx` within the object `shipToParty`.
		/// </summary>
		[JsonProperty("attention")]
		public string Attention { get; set; }

		/// <summary>
		/// First line of the address. For Amazon label only vendors, this field will have the value `xxxxx` within the ob
		/// ect `shipToParty`.
		/// </summary>
		[IsRequired]
		[JsonProperty("addressLine1")]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Additional address information, if required. For Amazon label only vendors, this field will have the value `xx
		/// xx` within the object `shipToParty`.
		/// </summary>
		[JsonProperty("addressLine2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// Additional address information, if required. For Amazon label only vendors, this field will have the value `xx
		/// xx` within the object `shipToParty`.
		/// </summary>
		[JsonProperty("addressLine3")]
		public string AddressLine3 { get; set; }

		/// <summary>
		/// The city where the person, business or institution is located. For Amazon label only vendors, this field will
		/// ave the value `xxxxx` within the object `shipToParty`.
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		/// The county where person, business or institution is located. For Amazon label only vendors, this field will ha
		/// e the value `xxxxx` within the object `shipToParty`.
		/// </summary>
		[JsonProperty("county")]
		public string County { get; set; }

		/// <summary>
		/// The district where person, business or institution is located. For Amazon label only vendors, this field will
		/// ave the value `xxxxx` within the object `shipToParty`.
		/// </summary>
		[JsonProperty("district")]
		public string District { get; set; }

		/// <summary>
		/// The state or region where person, business or institution is located.
		/// </summary>
		[IsRequired]
		[JsonProperty("stateOrRegion")]
		public string StateOrRegion { get; set; }

		/// <summary>
		/// The postal code of that address. It conatins a series of letters or digits or both, sometimes including spaces
		/// or punctuation.
		/// </summary>
		[JsonProperty("postalCode")]
		public string PostalCode { get; set; }

		/// <summary>
		/// The two digit country code. In ISO 3166-1 alpha-2 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		/// <summary>
		/// The phone number of the person, business or institution located at that address. For Amazon label only vendors
		/// this field will have the value `xxxxx` within the object `shipToParty`.
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; }
	}
}
