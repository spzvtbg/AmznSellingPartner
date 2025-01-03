namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Severity
	{
		/// <summary>
		/// Indicates an issue has occurred preventing the submission from processing, such as a validation error.
		/// </summary>
		[EnumMember(Value = "ERROR")]
		ERROR,

		/// <summary>
		/// Indicates an issue has occurred that should be reviewed, but has not prevented the submission from processing.
		/// </summary>
		[EnumMember(Value = "WARNING")]
		WARNING,

		/// <summary>
		/// Indicates additional information has been provided that should be reviewed.
		/// </summary>
		[EnumMember(Value = "INFO")]
		INFO,
	}
}
