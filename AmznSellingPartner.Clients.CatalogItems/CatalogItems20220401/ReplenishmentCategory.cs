namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ReplenishmentCategory
	{
		/// <summary>
		/// Indicates non-automated purchasing of inventory that has been allocated to Amazon by the v
		/// endor.
		/// </summary>
		[EnumMember(Value = "ALLOCATED")]
		ALLOCATED,

		/// <summary>
		/// Indicates non-automated purchasing of inventory.
		/// </summary>
		[EnumMember(Value = "BASIC_REPLENISHMENT")]
		BASIC_REPLENISHMENT,

		/// <summary>
		/// Indicates non-automated purchasing of inventory for seasonal items.
		/// </summary>
		[EnumMember(Value = "IN_SEASON")]
		IN_SEASON,

		/// <summary>
		/// Holding queue replenishment status before an item is `NEW_PRODUCT`.
		/// </summary>
		[EnumMember(Value = "LIMITED_REPLENISHMENT")]
		LIMITED_REPLENISHMENT,

		/// <summary>
		/// Indicates vendor is out of stock for a longer period of time and cannot backorder.
		/// </summary>
		[EnumMember(Value = "MANUFACTURER_OUT_OF_STOCK")]
		MANUFACTURER_OUT_OF_STOCK,

		/// <summary>
		/// Indicates a new item that Amazon does not yet stock in inventory.
		/// </summary>
		[EnumMember(Value = "NEW_PRODUCT")]
		NEW_PRODUCT,

		/// <summary>
		/// Indicates assortment parent used for detail page display, not actual items.
		/// </summary>
		[EnumMember(Value = "NON_REPLENISHABLE")]
		NON_REPLENISHABLE,

		/// <summary>
		/// Indicates drop ship inventory that Amazon does not stock in its fulfillment centers.
		/// </summary>
		[EnumMember(Value = "NON_STOCKUPABLE")]
		NON_STOCKUPABLE,

		/// <summary>
		/// Indicates item is obsolete and should not be ordered.
		/// </summary>
		[EnumMember(Value = "OBSOLETE")]
		OBSOLETE,

		/// <summary>
		/// Indicates active items that should be automatically ordered.
		/// </summary>
		[EnumMember(Value = "PLANNED_REPLENISHMENT")]
		PLANNED_REPLENISHMENT,
	}
}
