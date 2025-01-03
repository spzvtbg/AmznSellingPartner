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
		summaries,

		/// <summary>
		/// A JSON object that contains structured listing item attribute data, keyed by attribute name.
		/// </summary>
		[EnumMember(Value = "attributes")]
		attributes,

		/// <summary>
		/// Issues that are associated with the listing item.
		/// </summary>
		[EnumMember(Value = "issues")]
		issues,

		/// <summary>
		/// Current offers for the listing item.
		/// </summary>
		[EnumMember(Value = "offers")]
		offers,

		/// <summary>
		/// Fulfillment availability details for the listing item.
		/// </summary>
		[EnumMember(Value = "fulfillmentAvailability")]
		fulfillmentAvailability,

		/// <summary>
		/// Vendor procurement details for the listing item.
		/// </summary>
		[EnumMember(Value = "procurement")]
		procurement,

		/// <summary>
		/// Relationship details for a listing item (for example, variations).
		/// </summary>
		[EnumMember(Value = "relationships")]
		relationships,

		/// <summary>
		/// Product types associated with a listing item.
		/// </summary>
		[EnumMember(Value = "productTypes")]
		productTypes,

		/// <summary>
		/// Identifiers associated with the item in the Amazon catalog, such as Amazon Standard Identification Number
		/// (ASIN). Can only be requested when `mode` is `VALIDATION_PREVIEW`.
		/// </summary>
		[EnumMember(Value = "identifiers")]
		identifiers,
	}
}
