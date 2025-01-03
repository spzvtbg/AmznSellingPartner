namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum CompressionAlgorithm
	{
		/// <summary>
		/// The gzip compression algorithm.
		/// </summary>
		[EnumMember(Value = "GZIP")]
		GZIP,
	}
}
