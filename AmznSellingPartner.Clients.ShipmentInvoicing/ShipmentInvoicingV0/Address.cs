namespace AmznSellingPartner.Clients.ShipmentInvoicing.ShipmentInvoicingV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The shipping address details of the shipment
	/// </summary>
	public class Address : BaseClass
	{
		/// <summary>
		/// The name
		/// </summary>
		[JsonProperty("Name")]
		public string Name { get; set; }

		/// <summary>
		/// The street address
		/// </summary>
		[JsonProperty("AddressLine1")]
		public string AddressLine1 { get; set; }

		/// <summary>
		/// Additional street address information, if required
		/// </summary>
		[JsonProperty("AddressLine2")]
		public string AddressLine2 { get; set; }

		/// <summary>
		/// Additional street address information, if required
		/// </summary>
		[JsonProperty("AddressLine3")]
		public string AddressLine3 { get; set; }

		/// <summary>
		/// The city
		/// </summary>
		[JsonProperty("City")]
		public string City { get; set; }

		/// <summary>
		/// The county
		/// </summary>
		[JsonProperty("County")]
		public string County { get; set; }

		/// <summary>
		/// The district
		/// </summary>
		[JsonProperty("District")]
		public string District { get; set; }

		/// <summary>
		/// The state or region
		/// </summary>
		[JsonProperty("StateOrRegion")]
		public string StateOrRegion { get; set; }

		/// <summary>
		/// The postal code
		/// </summary>
		[JsonProperty("PostalCode")]
		public string PostalCode { get; set; }

		/// <summary>
		/// The country code
		/// </summary>
		[JsonProperty("CountryCode")]
		public string CountryCode { get; set; }

		/// <summary>
		/// The phone number
		/// </summary>
		[JsonProperty("Phone")]
		public string Phone { get; set; }

		[JsonProperty("AddressType")]
		public AddressTypeEnum AddressType { get; set; }
	}
}
