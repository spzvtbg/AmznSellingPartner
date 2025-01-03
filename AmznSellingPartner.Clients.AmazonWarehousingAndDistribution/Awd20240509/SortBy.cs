namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortBy
	{
		/// <summary>
		/// Sort by the time of update.
		/// </summary>
		[EnumMember(Value = "UPDATED_AT")]
		UPDATED_AT,

		/// <summary>
		/// Sort by the time of creation.
		/// </summary>
		[EnumMember(Value = "CREATED_AT")]
		CREATED_AT,
	}
}
