namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Op
	{
		/// <summary>
		/// The `add` operation adds or replaces the target property.
		/// </summary>
		[EnumMember(Value = "add")]
		Add,

		/// <summary>
		/// The `replace` operation adds or replaces the target property.
		/// </summary>
		[EnumMember(Value = "replace")]
		Replace,

		/// <summary>
		/// The `delete` operation removes the target property. Not supported for vendors (vendors will
		/// receive an HTTP status code 400 response).
		/// </summary>
		[EnumMember(Value = "delete")]
		Delete,
	}
}
