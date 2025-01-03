namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum IncludedDataSet
	{
		/// <summary>
		/// The contents of the content document.
		/// </summary>
		[EnumMember(Value = "CONTENTS")]
		CONTENTS,

		/// <summary>
		/// The metadata of the content document.
		/// </summary>
		[EnumMember(Value = "METADATA")]
		METADATA,
	}
}
