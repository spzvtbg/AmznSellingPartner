namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the seller's primary contact.
	/// </summary>
	public class PrimaryContact : BaseClass
	{
		/// <summary>
		/// The full name of the seller's primary contact.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The primary contact's residential address.
		/// </summary>
		[IsRequired]
		[JsonProperty("address")]
		public Address Address { get; set; }

		/// <summary>
		/// The non-Latin script version of the primary contact's name, if applicable.
		/// </summary>
		[JsonProperty("nonLatinName")]
		public string NonLatinName { get; set; }
	}
}
