namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventFilterType
	{
		[EnumMember(Value = "ANY_OFFER_CHANGED")]
		ANY_OFFER_CHANGED,

		[EnumMember(Value = "ORDER_CHANGE")]
		ORDER_CHANGE,
	}
}
