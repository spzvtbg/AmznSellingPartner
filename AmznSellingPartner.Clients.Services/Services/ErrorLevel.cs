namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ErrorLevel
	{
		/// <summary>
		/// Error
		/// </summary>
		[EnumMember(Value = "ERROR")]
		ERROR,

		/// <summary>
		/// Warning
		/// </summary>
		[EnumMember(Value = "WARNING")]
		WARNING,
	}
}
