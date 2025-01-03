namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum DeletionReason
	{
		/// <summary>
		/// The notification's content is recognized to be incorrect
		/// </summary>
		[EnumMember(Value = "INCORRECT_CONTENT")]
		INCORRECT_CONTENT,

		/// <summary>
		/// The notification was sent to incorrect seller
		/// </summary>
		[EnumMember(Value = "INCORRECT_RECIPIENT")]
		INCORRECT_RECIPIENT,
	}
}
