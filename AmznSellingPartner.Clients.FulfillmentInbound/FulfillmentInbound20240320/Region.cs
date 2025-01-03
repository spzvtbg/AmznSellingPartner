namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Representation of a location used within the inbounding experience.
	/// </summary>
	public class Region : BaseClass
	{
		/// <summary>
		/// ISO 3166 standard alpha-2 country code.
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		/// <summary>
		/// State.
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("state")]
		public string State { get; set; }

		/// <summary>
		/// An identifier for a warehouse, such as a FC, IXD, upstream storage.
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("warehouseId")]
		public string WarehouseId { get; set; }
	}
}
