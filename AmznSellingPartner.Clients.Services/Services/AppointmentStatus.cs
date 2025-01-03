namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum AppointmentStatus
	{
		/// <summary>
		/// Indicates that an appointment is scheduled.
		/// </summary>
		[EnumMember(Value = "ACTIVE")]
		ACTIVE,

		/// <summary>
		/// Indicates that the appointment is cancelled.
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,

		/// <summary>
		/// Indicates that the appointment is completed.
		/// </summary>
		[EnumMember(Value = "COMPLETED")]
		COMPLETED,
	}
}
