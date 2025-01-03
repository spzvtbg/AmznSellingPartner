namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The sort order.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortOrder
	{
		/// <summary>
		/// Sort the results in ascending order.
		/// </summary>
		[EnumMember(Value = "ASC")]
		ASC,

		/// <summary>
		/// Sort the results in descending order.
		/// </summary>
		[EnumMember(Value = "DESC")]
		DESC,
	}
}
