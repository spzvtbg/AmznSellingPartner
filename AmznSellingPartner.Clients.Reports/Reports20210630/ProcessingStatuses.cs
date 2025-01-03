namespace AmznSellingPartner.Clients.Reports.Reports20210630
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ProcessingStatuses
	{
		/// <summary>
		/// The report was cancelled. There are two ways a report can be cancelled: an explicit cancellation request befor
		/// the report starts processing, or an automatic cancellation if there is no data to return.
		/// </summary>
		[EnumMember(Value = "CANCELLED")]
		CANCELLED,

		/// <summary>
		/// The report has completed processing.
		/// </summary>
		[EnumMember(Value = "DONE")]
		DONE,

		/// <summary>
		/// The report was aborted due to a fatal error.
		/// </summary>
		[EnumMember(Value = "FATAL")]
		FATAL,

		/// <summary>
		/// The report is being processed.
		/// </summary>
		[EnumMember(Value = "IN_PROGRESS")]
		IN_PROGRESS,

		/// <summary>
		/// The report has not yet started processing. It may be waiting for another `IN_PROGRESS` report.
		/// </summary>
		[EnumMember(Value = "IN_QUEUE")]
		IN_QUEUE,
	}
}
