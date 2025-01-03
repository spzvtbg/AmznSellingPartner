namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortBy
	{
		/// <summary>
		/// Stock Keeping Unit, a seller-specified identifier for an Amazon listing
		/// </summary>
		[EnumMember(Value = "sku")]
		sku,

		/// <summary>
		/// The date when the listing item was created
		/// Values are in [ISO 8601](https://developer-docs
		/// amazon
		/// com/sp-api/docs/iso-8601) date-time format
		/// </summary>
		[EnumMember(Value = "createdDate")]
		createdDate,

		/// <summary>
		/// The date when the listing item was last updated
		/// Values are in [ISO 8601](https://developer-docs
		/// amazon
		/// com/sp-api/docs/iso-8601) date-time format
		/// </summary>
		[EnumMember(Value = "lastUpdatedDate")]
		lastUpdatedDate,
	}
}
