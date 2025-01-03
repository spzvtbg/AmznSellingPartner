namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum WithStatus
	{
		/// <summary>
		/// The listings item can be purchased by shoppers
		/// This status does not apply to vendor listings
		/// </summary>
		[EnumMember(Value = "BUYABLE")]
		BUYABLE,

		/// <summary>
		/// The listings item is visible to shoppers
		/// </summary>
		[EnumMember(Value = "DISCOVERABLE")]
		DISCOVERABLE,
	}
}
