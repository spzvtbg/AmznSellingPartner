namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Sort order for a collection of items
	/// For example, order or shipment
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortOrder
	{
		/// <summary>
		/// Sorts the collection in ascending order
		/// </summary>
		[EnumMember(Value = "ASCENDING")]
		ASCENDING,

		/// <summary>
		/// Sorts the collection in descending order
		/// </summary>
		[EnumMember(Value = "DESCENDING")]
		DESCENDING,
	}
}
