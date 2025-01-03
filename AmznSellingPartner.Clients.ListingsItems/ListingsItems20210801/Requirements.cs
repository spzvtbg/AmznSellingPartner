namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Requirements
	{
		/// <summary>
		/// Indicates the submitted data contains product facts and sales terms
		/// </summary>
		[EnumMember(Value = "LISTING")]
		LISTING,

		/// <summary>
		/// Indicates the submitted data contains product facts only
		/// </summary>
		[EnumMember(Value = "LISTING_PRODUCT_ONLY")]
		LISTING_PRODUCT_ONLY,

		/// <summary>
		/// Indicates the submitted data contains sales terms only
		/// Not supported for vendors (vendors will receive an HTTP status code 400 response)
		/// </summary>
		[EnumMember(Value = "LISTING_OFFER_ONLY")]
		LISTING_OFFER_ONLY,
	}
}
