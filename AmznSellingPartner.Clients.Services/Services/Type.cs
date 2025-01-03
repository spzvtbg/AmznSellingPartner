namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Type
	{
		/// <summary>
		/// Reduce resource (store) capacity because of an appointment
		/// </summary>
		[EnumMember(Value = "APPOINTMENT")]
		APPOINTMENT,

		/// <summary>
		/// Reduce resource (store) capacity because technician(s) are travelling
		/// </summary>
		[EnumMember(Value = "TRAVEL")]
		TRAVEL,

		/// <summary>
		/// Reduce resource (store) capacity because technician(s) are on vacation
		/// </summary>
		[EnumMember(Value = "VACATION")]
		VACATION,

		/// <summary>
		/// Reduce resource (store) capacity because technician(s) are on break
		/// </summary>
		[EnumMember(Value = "BREAK")]
		BREAK,

		/// <summary>
		/// Reduce resource (store) capacity because technician(s) are in training
		/// </summary>
		[EnumMember(Value = "TRAINING")]
		TRAINING,
	}
}
