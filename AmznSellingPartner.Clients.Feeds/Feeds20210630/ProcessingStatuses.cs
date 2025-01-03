namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProcessingStatuses
	{
		/// <summary>
		/// The feed was cancelled before it started processing.
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,

		/// <summary>
		/// The feed has completed processing. Examine the contents of the result document to determine if there were any
		/// rrors during processing.
		/// </summary>
		[EnumMember(Value = "DONE")]
		DONE,

		/// <summary>
		/// The feed was aborted due to a fatal error. Some, none, or all of the operations within the feed may have compl
		/// ted successfully.
		/// </summary>
		[EnumMember(Value = "FATAL")]
		FATAL,

		/// <summary>
		/// The feed is being processed.
		/// </summary>
		[EnumMember(Value = "IN_PROGRESS")]
		IN_PROGRESS,

		/// <summary>
		/// The feed has not yet started processing. It may be waiting for another IN_PROGRESS feed.
		/// </summary>
		[EnumMember(Value = "IN_QUEUE")]
		IN_QUEUE,
	}
}
