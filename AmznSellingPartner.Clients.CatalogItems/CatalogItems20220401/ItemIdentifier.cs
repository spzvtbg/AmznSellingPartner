namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Identifier associated with the item in the Amazon catalog, such as a UPC or EAN identifier.
	/// </summary>
	public class ItemIdentifier : BaseClass
	{
		/// <summary>
		/// Type of identifier, such as UPC, EAN, or ISBN.
		/// </summary>
		[JsonProperty("identifierType")]
		[IsRequired]
		public string IdentifierType { get; set; }

		/// <summary>
		/// Identifier.
		/// </summary>
		[JsonProperty("identifier")]
		[IsRequired]
		public string Identifier { get; set; }
	}
}
