namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum WithIssueSeverity
	{
		/// <summary>
		/// Indicates an issue has occurred that should be reviewed, but it has not prevented the submission
		/// from processing.
		/// </summary>
		[EnumMember(Value = "WARNING")]
		WARNING,

		/// <summary>
		/// Indicates that an issue has occurred, which prevented the submission from processing. For example,
		/// a validation error.
		/// </summary>
		[EnumMember(Value = "ERROR")]
		ERROR,
	}
}
