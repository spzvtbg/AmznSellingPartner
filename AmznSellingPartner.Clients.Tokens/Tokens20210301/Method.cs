namespace AmznSellingPartner.Clients.Tokens.Tokens20210301
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Method
	{
		/// <summary>
		/// The GET method
		/// </summary>
		[EnumMember(Value = "GET")]
		GET,

		/// <summary>
		/// The PUT method
		/// </summary>
		[EnumMember(Value = "PUT")]
		PUT,

		/// <summary>
		/// The POST method
		/// </summary>
		[EnumMember(Value = "POST")]
		POST,

		/// <summary>
		/// The DELETE method
		/// </summary>
		[EnumMember(Value = "DELETE")]
		DELETE,
	}
}
