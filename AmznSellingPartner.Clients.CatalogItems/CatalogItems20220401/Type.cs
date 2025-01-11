namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type
	{
		/// <summary>
		/// The Amazon catalog item in the request is a variation parent or variation child of the related
		/// item(s) indicated by ASIN.
		/// </summary>
		[EnumMember(Value = "VARIATION")]
		VARIATION,

		/// <summary>
		/// The Amazon catalog item in the request is a package container or is contained by the related
		/// item(s) indicated by ASIN.
		/// </summary>
		[EnumMember(Value = "PACKAGE_HIERARCHY")]
		PACKAGE_HIERARCHY,
	}
}
