namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The postal address information
	/// </summary>
	public class Address : BaseClass
	{
		[IsRequired]
		[JsonProperty("Name")]
		public AddressName Name { get; set; }

		[IsRequired]
		[JsonProperty("AddressLine1")]
		public AddressLine1 AddressLine1 { get; set; }

		[JsonProperty("AddressLine2")]
		public AddressLine2 AddressLine2 { get; set; }

		[JsonProperty("AddressLine3")]
		public AddressLine3 AddressLine3 { get; set; }

		[JsonProperty("DistrictOrCounty")]
		public DistrictOrCounty DistrictOrCounty { get; set; }

		[IsRequired]
		[JsonProperty("Email")]
		public EmailAddress Email { get; set; }

		[IsRequired]
		[JsonProperty("City")]
		public City City { get; set; }

		[JsonProperty("StateOrProvinceCode")]
		public StateOrProvinceCode StateOrProvinceCode { get; set; }

		[IsRequired]
		[JsonProperty("PostalCode")]
		public PostalCode PostalCode { get; set; }

		[IsRequired]
		[JsonProperty("CountryCode")]
		public CountryCode CountryCode { get; set; }

		[IsRequired]
		[JsonProperty("Phone")]
		public PhoneNumber Phone { get; set; }
	}
}
