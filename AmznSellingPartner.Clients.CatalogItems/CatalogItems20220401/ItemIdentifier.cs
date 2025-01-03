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
		[IsRequired]
		[JsonProperty("identifierType")]
		public string IdentifierType { get; set; }

		/// <summary>
		/// Identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("identifier")]
		public string Identifier { get; set; }
	}
}
