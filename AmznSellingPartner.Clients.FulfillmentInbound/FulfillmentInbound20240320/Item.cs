namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Information associated with a single SKU in the seller's catalog.
	/// </summary>
	public class Item : BaseClass
	{
		/// <summary>
		/// The Amazon Standard Identification Number (ASIN) of the item.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(10)]
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetim
		/// format with pattern`YYYY-MM-DD`. The same MSKU with different expiration dates cannot go into the same box.
		/// </summary>
		[Pattern("^([0-9]{4})-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])")]
		[JsonProperty("expiration")]
		public string Expiration { get; set; }

		/// <summary>
		/// A unique identifier assigned by Amazon to products stored in and fulfilled from an Amazon fulfillment center.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(10)]
		[JsonProperty("fnsku")]
		public string Fnsku { get; set; }

		/// <summary>
		/// Specifies who will label the items. Options include `AMAZON`, `SELLER`, and `NONE`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("labelOwner")]
		public string LabelOwner { get; set; }

		/// <summary>
		/// The manufacturing lot code.
		/// </summary>
		[MinLength(1)]
		[MaxLength(256)]
		[JsonProperty("manufacturingLotCode")]
		public string ManufacturingLotCode { get; set; }

		/// <summary>
		/// The merchant SKU, a merchant-supplied identifier of a specific SKU.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(40)]
		[JsonProperty("msku")]
		public string Msku { get; set; }

		/// <summary>
		/// Special preparations that are required for an item.
		/// </summary>
		[IsRequired]
		[JsonProperty("prepInstructions")]
		public List<PrepInstruction> PrepInstructions { get; set; }

		/// <summary>
		/// The number of the specified MSKU.
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }
	}
}
