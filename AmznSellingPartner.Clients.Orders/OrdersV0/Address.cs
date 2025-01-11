namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The shipping address for the order.
	/// </summary>
	public class Address : BaseClass
	{
		/// <summary>
		/// The name.
		/// </summary>
		[JsonProperty("Name")]
		[IsRequired]
		public string Name { get; set; } 

		/// <summary>
		/// The company name of the recipient.  **Note**: This attribute is only available for shipping
		/// address.
		/// </summary>
		[JsonProperty("CompanyName")]
		public string CompanyName { get; set; } 

		/// <summary>
		/// The street address.
		/// </summary>
		[JsonProperty("AddressLine1")]
		public string AddressLine1 { get; set; } 

		/// <summary>
		/// Additional street address information, if required.
		/// </summary>
		[JsonProperty("AddressLine2")]
		public string AddressLine2 { get; set; } 

		/// <summary>
		/// Additional street address information, if required.
		/// </summary>
		[JsonProperty("AddressLine3")]
		public string AddressLine3 { get; set; } 

		/// <summary>
		/// The city.
		/// </summary>
		[JsonProperty("City")]
		public string City { get; set; } 

		/// <summary>
		/// The county.
		/// </summary>
		[JsonProperty("County")]
		public string County { get; set; } 

		/// <summary>
		/// The district.
		/// </summary>
		[JsonProperty("District")]
		public string District { get; set; } 

		/// <summary>
		/// The state or region.
		/// </summary>
		[JsonProperty("StateOrRegion")]
		public string StateOrRegion { get; set; } 

		/// <summary>
		/// The municipality.
		/// </summary>
		[JsonProperty("Municipality")]
		public string Municipality { get; set; } 

		/// <summary>
		/// The postal code.
		/// </summary>
		[JsonProperty("PostalCode")]
		public string PostalCode { get; set; } 

		/// <summary>
		/// The country code. A two-character country code, in ISO 3166-1 alpha-2 format.
		/// </summary>
		[JsonProperty("CountryCode")]
		public string CountryCode { get; set; } 

		/// <summary>
		/// The phone number of the buyer.  **Note**:  1. This attribute is only available for shipping
		/// address. 2. In some cases, the buyer phone number is suppressed:  a. Phone is suppressed for
		/// all `AFN` (fulfilled by Amazon) orders. b. Phone is suppressed for the shipped `MFN` (fulfilled
		/// by seller) order when the current date is past the Latest Delivery Date.
		/// </summary>
		[JsonProperty("Phone")]
		public string Phone { get; set; } 

		/// <summary>
		/// The container for address extended fields. For example, street name or street number.   **Note**:
		/// This attribute is currently only available with Brazil shipping addresses.
		/// </summary>
		[JsonProperty("ExtendedFields")]
		public AddressExtendedFields ExtendedFields { get; set; } 

		/// <summary>
		/// The address type of the shipping address.
		/// </summary>
		[JsonProperty("AddressType")]
		public AddressType AddressType { get; set; } 
	}
}
