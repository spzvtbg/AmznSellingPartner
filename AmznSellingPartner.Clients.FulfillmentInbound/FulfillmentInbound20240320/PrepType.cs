namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Preparation instructions for shipping an item to Amazon's fulfillment network. For more information about
	/// preparing items for shipment to Amazon's fulfillment network, refer to [Seller Central Help for your
	/// marketplace](https://developer-docs.amazon.com/sp-api/docs/seller-central-urls).
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrepType
	{
		/// <summary>
		/// The item requires black shrink wrapping.
		/// </summary>
		[EnumMember(Value = "ITEM_BLACK_SHRINKWRAP")]
		ITEM_BLACK_SHRINKWRAP,

		/// <summary>
		/// The item requires a blank sticker to obscure a bad barcode that cannot be covered by another sticker
		/// .
		/// </summary>
		[EnumMember(Value = "ITEM_BLANKSTK")]
		ITEM_BLANKSTK,

		/// <summary>
		/// Products may require overboxing when there are safety concerns over sharp items, fragile items, hazardous
		/// liquids, and vinyl records. For items over 4.5 kg, use double-wall corrugated boxes.
		/// </summary>
		[EnumMember(Value = "ITEM_BOXING")]
		ITEM_BOXING,

		/// <summary>
		/// The item requires bubble wrapping.
		/// </summary>
		[EnumMember(Value = "ITEM_BUBBLEWRAP")]
		ITEM_BUBBLEWRAP,

		/// <summary>
		/// To prevent leakage, the product needs to have a secondary seal in one of the following types: Induction
		/// seal, safety ring, clips, heat shrink plastic band, or boxing.
		/// </summary>
		[EnumMember(Value = "ITEM_CAP_SEALING")]
		ITEM_CAP_SEALING,

		/// <summary>
		/// The item requires taking apart a set of items labeled for individual sale. Remove tape or shrink wrap
		/// that groups multiple inventory units together.
		/// </summary>
		[EnumMember(Value = "ITEM_DEBUNDLE")]
		ITEM_DEBUNDLE,

		/// <summary>
		/// The item must be placed on a hanger.
		/// </summary>
		[EnumMember(Value = "ITEM_HANG_GARMENT")]
		ITEM_HANG_GARMENT,

		/// <summary>
		/// The FNSKU label must be applied to the item.
		/// </summary>
		[EnumMember(Value = "ITEM_LABELING")]
		ITEM_LABELING,

		/// <summary>
		/// The item does not require any prep.
		/// </summary>
		[EnumMember(Value = "ITEM_NO_PREP")]
		ITEM_NO_PREP,

		/// <summary>
		/// The item requires polybagging.
		/// </summary>
		[EnumMember(Value = "ITEM_POLYBAGGING")]
		ITEM_POLYBAGGING,

		/// <summary>
		/// The item cannot be shipped on a hanger.
		/// </summary>
		[EnumMember(Value = "ITEM_RMOVHANG")]
		ITEM_RMOVHANG,

		/// <summary>
		/// Units that are sets must be labeled as sets on their packaging. The barcodes on the individual items
		/// must not face outward and must not require covering.
		/// </summary>
		[EnumMember(Value = "ITEM_SETCREAT")]
		ITEM_SETCREAT,

		/// <summary>
		/// Products that are sets must be marked as sets on their packaging. Add a label to the unit that clearly
		/// states that the products must be received and sold as a single unit. For example, if a set of six unique
		/// toy cars is sold as one unit, the packaging for each car must indicate that it is part of the set.
		/// </summary>
		[EnumMember(Value = "ITEM_SETSTK")]
		ITEM_SETSTK,

		/// <summary>
		/// The item ships in its original product packaging.
		/// </summary>
		[EnumMember(Value = "ITEM_SIOC")]
		ITEM_SIOC,

		/// <summary>
		/// Poly bags with an opening of 12 cm or larger (measured when flat) must have a suffocation warning. This
		/// warning must be printed on the bag or attached as a label.
		/// </summary>
		[EnumMember(Value = "ITEM_SUFFOSTK")]
		ITEM_SUFFOSTK,

		/// <summary>
		/// Indicates that taping is required.
		/// </summary>
		[EnumMember(Value = "ITEM_TAPING")]
		ITEM_TAPING,
	}
}
