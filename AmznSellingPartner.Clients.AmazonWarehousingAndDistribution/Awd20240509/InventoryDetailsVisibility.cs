namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Enum to specify if returned summaries should include additional summarized inventory details
	/// and quantities.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum InventoryDetailsVisibility
	{
		/// <summary>
		/// Show the additional summarized inventory details.
		/// </summary>
		[EnumMember(Value = "SHOW")]
		SHOW,

		/// <summary>
		/// Hide the additional summarized inventory details.
		/// </summary>
		[EnumMember(Value = "HIDE")]
		HIDE,
	}
}
