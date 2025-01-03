namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The submission status of the content document
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContentStatus
	{
		/// <summary>
		/// The content is approved and will be published to applied ASINs
		/// </summary>
		[EnumMember(Value = "APPROVED")]
		APPROVED,

		/// <summary>
		/// The content has not yet been submitted for approval
		/// </summary>
		[EnumMember(Value = "DRAFT")]
		DRAFT,

		/// <summary>
		/// The content has been rejected in moderation and needs to be revised and resubmitted based on the rejection rea
		/// ons provided
		/// </summary>
		[EnumMember(Value = "REJECTED")]
		REJECTED,

		/// <summary>
		/// The content has been submitted for approval and is currently waiting for moderation
		/// </summary>
		[EnumMember(Value = "SUBMITTED")]
		SUBMITTED,
	}
}
