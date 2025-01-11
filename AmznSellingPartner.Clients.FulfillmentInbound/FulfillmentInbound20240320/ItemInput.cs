namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Defines an item's input parameters.
	/// </summary>
	public class ItemInput : BaseClass
	{
		/// <summary>
		/// The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `YYYY-MM-DD`. Items with the same MSKU but different expiration
		/// dates cannot go into the same box.
		/// </summary>
		[JsonProperty("expiration")]
		[Pattern("^([0-9]{4})-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])")]
		public string Expiration { get; set; } 

		[JsonProperty("labelOwner")]
		[IsRequired]
		public LabelOwner LabelOwner { get; set; } 

		/// <summary>
		/// The manufacturing lot code.
		/// </summary>
		[JsonProperty("manufacturingLotCode")]
		[MinLength(1)]
		[MaxLength(256)]
		public string ManufacturingLotCode { get; set; } 

		/// <summary>
		/// The merchant SKU, a merchant-supplied identifier of a specific SKU.
		/// </summary>
		[JsonProperty("msku")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(40)]
		public string Msku { get; set; } 

		[JsonProperty("prepOwner")]
		[IsRequired]
		public PrepOwner PrepOwner { get; set; } 

		/// <summary>
		/// The number of units of the specified MSKU that will be shipped.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		public int Quantity { get; set; } 
	}
}
