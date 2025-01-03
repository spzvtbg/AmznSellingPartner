namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceJobStatus
	{
		/// <summary>
		/// Jobs which are not serviced.
		/// </summary>
		[EnumMember(Value = "NOT_SERVICED")]
		NOT_SERVICED,

		/// <summary>
		/// Jobs which are cancelled.
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,

		/// <summary>
		/// Jobs successfully completed.
		/// </summary>
		[EnumMember(Value = "COMPLETED")]
		COMPLETED,

		/// <summary>
		/// Jobs which are pending schedule.
		/// </summary>
		[EnumMember(Value = "PENDING_SCHEDULE")]
		PENDING_SCHEDULE,

		/// <summary>
		/// Jobs which are not fulfillable.
		/// </summary>
		[EnumMember(Value = "NOT_FULFILLABLE")]
		NOT_FULFILLABLE,

		/// <summary>
		/// Jobs which are on hold.
		/// </summary>
		[EnumMember(Value = "HOLD")]
		HOLD,

		/// <summary>
		/// Jobs for which payment was declined.
		/// </summary>
		[EnumMember(Value = "PAYMENT_DECLINED")]
		PAYMENT_DECLINED,
	}
}
