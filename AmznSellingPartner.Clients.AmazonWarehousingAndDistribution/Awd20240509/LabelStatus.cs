namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The status of your label
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LabelStatus
	{
		/// <summary>
		/// Labels are being generated
		/// </summary>
		[EnumMember(Value = "GENERATING")]
		GENERATING,

		/// <summary>
		/// Labels are generated
		/// </summary>
		[EnumMember(Value = "GENERATED")]
		GENERATED,

		/// <summary>
		/// Label generation failed
		/// </summary>
		[EnumMember(Value = "GENERATION_FAILED")]
		GENERATION_FAILED,

		/// <summary>
		/// Not yet ready to start label generation
		/// </summary>
		[EnumMember(Value = "NOT_READY")]
		NOT_READY,
	}
}
