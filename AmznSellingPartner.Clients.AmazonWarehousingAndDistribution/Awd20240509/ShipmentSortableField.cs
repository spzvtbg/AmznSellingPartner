namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Denotes the field name on which the shipments are to be sorted
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ShipmentSortableField
	{
		/// <summary>
		/// Sort by updated at timestamp
		/// </summary>
		[EnumMember(Value = "UPDATED_AT")]
		UPDATED_AT,

		/// <summary>
		/// Sort by created at timestamp
		/// </summary>
		[EnumMember(Value = "CREATED_AT")]
		CREATED_AT,
	}
}
