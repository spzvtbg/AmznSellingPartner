namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProcessingStatuses
	{
		/// <summary>
		/// The query was cancelled before it began processing.
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,

		/// <summary>
		/// The query has completed processing.
		/// </summary>
		[EnumMember(Value = "DONE")]
		DONE,

		/// <summary>
		/// The query was aborted due to a fatal error.
		/// </summary>
		[EnumMember(Value = "FATAL")]
		FATAL,

		/// <summary>
		/// The query is being processed.
		/// </summary>
		[EnumMember(Value = "IN_PROGRESS")]
		IN_PROGRESS,

		/// <summary>
		/// The query has not yet started processing. It may be waiting for another `IN_PROGRESS` quer
		/// y.
		/// </summary>
		[EnumMember(Value = "IN_QUEUE")]
		IN_QUEUE,
	}
}
