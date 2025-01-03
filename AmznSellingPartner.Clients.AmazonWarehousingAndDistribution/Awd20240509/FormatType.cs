namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The label format type extension
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FormatType
	{
		/// <summary>
		/// PDF format
		/// </summary>
		[EnumMember(Value = "PDF")]
		PDF,
	}
}
