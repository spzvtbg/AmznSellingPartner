namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The default payment method type
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AssignmentType
	{
		/// <summary>
		/// The default deposit method
		/// </summary>
		[EnumMember(Value = "DEFAULT_DEPOSIT_METHOD")]
		DEFAULT_DEPOSIT_METHOD,
	}
}
