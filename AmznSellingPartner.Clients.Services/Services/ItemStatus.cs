namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ItemStatus
	{
		/// <summary>
		/// Indicates the item is yet to be shipped
		/// </summary>
		[EnumMember(Value = "ACTIVE")]
		ACTIVE,

		/// <summary>
		/// Indicates the item has been cancelled
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,

		/// <summary>
		/// Indicates the item is shipped but not delivered
		/// </summary>
		[EnumMember(Value = "SHIPPED")]
		SHIPPED,

		/// <summary>
		/// Indicates the item is delivered
		/// </summary>
		[EnumMember(Value = "DELIVERED")]
		DELIVERED,
	}
}
