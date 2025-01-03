namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Defines an item's input parameters
	/// </summary>
	public class ItemInput : BaseClass
	{
		/// <summary>
		/// The expiration date of the MSKU
		/// In [ISO 8601](https://developer-docs
		/// amazon
		/// com/sp-api/docs/iso-8601) datetime format with pattern `YYYY-MM-DD`
		/// Items with the same MSKU but different expiration dates cannot go into the same box
		/// </summary>
		[Pattern("^([0-9]{4})-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])")]
		[JsonProperty("expiration")]
		public string Expiration { get; set; }

		[IsRequired]
		[JsonProperty("labelOwner")]
		public LabelOwner LabelOwner { get; set; }

		/// <summary>
		/// The manufacturing lot code
		/// </summary>
		[MinLength(1)]
		[MaxLength(256)]
		[JsonProperty("manufacturingLotCode")]
		public string ManufacturingLotCode { get; set; }

		/// <summary>
		/// The merchant SKU, a merchant-supplied identifier of a specific SKU
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(40)]
		[JsonProperty("msku")]
		public string Msku { get; set; }

		[IsRequired]
		[JsonProperty("prepOwner")]
		public PrepOwner PrepOwner { get; set; }

		/// <summary>
		/// The number of units of the specified MSKU that will be shipped
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }
	}
}
