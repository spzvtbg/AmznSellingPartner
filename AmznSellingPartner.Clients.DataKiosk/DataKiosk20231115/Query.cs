namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Detailed information about the query.
	/// </summary>
	public class Query : BaseClass
	{
		/// <summary>
		/// The query identifier. This identifier is unique only in combination with a selling partner account I
		/// D.
		/// </summary>
		[JsonProperty("queryId")]
		[IsRequired]
		public string QueryId { get; set; } 

		/// <summary>
		/// The submitted query.
		/// </summary>
		[JsonProperty("query")]
		[IsRequired]
		public string QueryValue { get; set; } 

		/// <summary>
		/// The date and time when the query was created, in ISO 8601 date time format.
		/// </summary>
		[JsonProperty("createdTime")]
		[IsRequired]
		public DateTimeValue CreatedTime { get; set; } 

		/// <summary>
		/// The processing status of the query.
		/// </summary>
		[JsonProperty("processingStatus")]
		[IsRequired]
		public ProcessingStatus ProcessingStatus { get; set; } 

		/// <summary>
		/// The date and time when the query processing started, in ISO 8601 date time format.
		/// </summary>
		[JsonProperty("processingStartTime")]
		public DateTimeValue ProcessingStartTime { get; set; } 

		/// <summary>
		/// The date and time when the query processing completed, in ISO 8601 date time format.
		/// </summary>
		[JsonProperty("processingEndTime")]
		public DateTimeValue ProcessingEndTime { get; set; } 

		/// <summary>
		/// The data document identifier. This identifier is only present when there is data available as a result
		/// of the query. This identifier is unique only in combination with a selling partner account ID. Pass this
		/// identifier into the `getDocument` operation to get the information required to retrieve the data document's
		/// contents.
		/// </summary>
		[JsonProperty("dataDocumentId")]
		public string DataDocumentId { get; set; } 

		/// <summary>
		/// The error document identifier. This identifier is only present when an error occurs during query processing.
		/// This identifier is unique only in combination with a selling partner account ID. Pass this identifier
		/// into the `getDocument` operation to get the information required to retrieve the error document's co
		/// ntents.
		/// </summary>
		[JsonProperty("errorDocumentId")]
		public string ErrorDocumentId { get; set; } 

		/// <summary>
		/// When a query produces results that are not included in the data document, pagination occurs. This means
		/// the results are divided into pages. To retrieve the next page, you must pass a `CreateQuerySpecification`
		/// object with `paginationToken` set to this object's `nextToken` and with `query` set to this object's
		/// `query` in the subsequent `createQuery` request. When there are no more pages to fetch, the `nextToken`
		/// field will be absent.
		/// </summary>
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; } 
	}
}
