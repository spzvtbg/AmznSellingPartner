namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// Generation Status
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum GenerationStatus
	{
		/// <summary>
		/// Genertaion is succesfully completed
		/// </summary>
		[EnumMember(Value = "Completed")]
		Completed,

		/// <summary>
		/// Genertaion is in Progress
		/// </summary>
		[EnumMember(Value = "InProgress")]
		InProgress,
	}
}
