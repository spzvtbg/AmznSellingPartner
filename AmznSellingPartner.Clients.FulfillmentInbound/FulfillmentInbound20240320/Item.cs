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
		[JsonProperty("asin")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(10)]
		public string Asin { get; set; }

		/// <summary>
		/// The expiration date of the MSKU. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern`YYYY-MM-DD`. The same MSKU with different expiration dates cannot go into
		/// the same box.
		/// </summary>
		[JsonProperty("expiration")]
		[Pattern("^([0-9]{4})-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])")]
		public string Expiration { get; set; }

		/// <summary>
		/// A unique identifier assigned by Amazon to products stored in and fulfilled from an Amazon fulfillment
		/// center.
		/// </summary>
		[JsonProperty("fnsku")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(10)]
		public string Fnsku { get; set; }

		/// <summary>
		/// Specifies who will label the items. Options include `AMAZON`, `SELLER`, and `NONE`.
		/// </summary>
		[JsonProperty("labelOwner")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string LabelOwner { get; set; }

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

		/// <summary>
		/// Special preparations that are required for an item.
		/// </summary>
		[JsonProperty("prepInstructions")]
		[IsRequired]
		public List<PrepInstruction> PrepInstructions { get; set; }

		/// <summary>
		/// The number of the specified MSKU.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		public int Quantity { get; set; }
	}
}
