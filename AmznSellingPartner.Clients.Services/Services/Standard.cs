namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Standard
	{
		/// <summary>
		/// The Advanced Encryption Standard (AES)
		/// </summary>
		[EnumMember(Value = "AES")]
		AES,
	}
}
