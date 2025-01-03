namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ServiceLocationType
	{
		/// <summary>
		/// Indicates the service for the service job is performed at the customers home address
		/// </summary>
		[EnumMember(Value = "IN_HOME")]
		IN_HOME,

		/// <summary>
		/// Indicates the service for the service job is performed at the service providers store
		/// </summary>
		[EnumMember(Value = "IN_STORE")]
		IN_STORE,

		/// <summary>
		/// Indicates the service for the service job is performed remotely
		/// </summary>
		[EnumMember(Value = "ONLINE")]
		ONLINE,
	}
}
