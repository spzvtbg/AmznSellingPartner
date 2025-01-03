namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request body schema for the `putListingsItem` operation.
	/// </summary>
	public class ListingsItemPutRequest : BaseClass
	{
		/// <summary>
		/// The Amazon product type of the listings item.
		/// </summary>
		[IsRequired]
		[JsonProperty("productType")]
		public string ProductType { get; set; }

		/// <summary>
		/// The name of the requirements set for the provided data.
		/// </summary>
		[JsonProperty("requirements")]
		public Requirements Requirements { get; set; }

		/// <summary>
		/// A JSON object containing structured listings item attribute data keyed by attribute name.
		/// </summary>
		[IsRequired]
		[JsonProperty("attributes")]
		public Attributes Attributes { get; set; }
	}
}
