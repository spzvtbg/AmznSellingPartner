namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type
	{
		/// <summary>
		/// The listing item in the request is a variation parent or variation child of the related listing items,
		/// indicated by SKU.
		/// </summary>
		[EnumMember(Value = "VARIATION")]
		VARIATION,

		/// <summary>
		/// The listing item in the request is a package container or is contained by the related listing items,
		/// indicated by SKU.
		/// </summary>
		[EnumMember(Value = "PACKAGE_HIERARCHY")]
		PACKAGE_HIERARCHY,
	}
}
