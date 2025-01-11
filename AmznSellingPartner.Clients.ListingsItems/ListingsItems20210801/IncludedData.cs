namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum IncludedData
	{
		/// <summary>
		/// Summary details for the listing item.
		/// </summary>
		[EnumMember(Value = "summaries")]
		Summaries,

		/// <summary>
		/// A JSON object that contains structured listing item attribute data, keyed by attribute nam
		/// e.
		/// </summary>
		[EnumMember(Value = "attributes")]
		Attributes,

		/// <summary>
		/// Issues that are associated with the listing item.
		/// </summary>
		[EnumMember(Value = "issues")]
		Issues,

		/// <summary>
		/// Current offers for the listing item.
		/// </summary>
		[EnumMember(Value = "offers")]
		Offers,

		/// <summary>
		/// Fulfillment availability details for the listing item.
		/// </summary>
		[EnumMember(Value = "fulfillmentAvailability")]
		FulfillmentAvailability,

		/// <summary>
		/// Vendor procurement details for the listing item.
		/// </summary>
		[EnumMember(Value = "procurement")]
		Procurement,

		/// <summary>
		/// Relationship details for a listing item (for example, variations).
		/// </summary>
		[EnumMember(Value = "relationships")]
		Relationships,

		/// <summary>
		/// Product types associated with a listing item.
		/// </summary>
		[EnumMember(Value = "productTypes")]
		ProductTypes,

		/// <summary>
		/// Identifiers associated with the item in the Amazon catalog, such as Amazon Standard Identification
		/// Number (ASIN). Can only be requested when `mode` is `VALIDATION_PREVIEW`.
		/// </summary>
		[EnumMember(Value = "identifiers")]
		Identifiers,
	}
}
