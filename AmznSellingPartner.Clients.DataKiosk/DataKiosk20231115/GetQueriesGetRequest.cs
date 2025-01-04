namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using System;

	[HttpGet("/dataKiosk/2023-11-15/queries")]
	public class GetQueriesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A list of processing statuses used to filter queries.
		/// </summary>
		[InQuery("processingStatuses")]
		[MinItems(1)]
		public CsvValue<ProcessingStatuses> ProcessingStatuses { get; set; }

		/// <summary>
		/// The maximum number of queries to return in a single call.
		/// </summary>
		[InQuery("pageSize")]
		[Minimum(1)]
		[Maximum(100)]
		public int PageSize { get; set; }

		/// <summary>
		/// The earliest query creation date and time for queries to include in the response, in ISO 8601 date time
		/// format. The default is 90 days ago.
		/// </summary>
		[InQuery("createdSince")]
		public DateTime CreatedSince { get; set; }

		/// <summary>
		/// The latest query creation date and time for queries to include in the response, in ISO 8601 date time
		/// format. The default is the time of the `getQueries` request.
		/// </summary>
		[InQuery("createdUntil")]
		public DateTime CreatedUntil { get; set; }

		/// <summary>
		/// A token to fetch a certain page of results when there are multiple pages of results available. The value
		/// of this token is fetched from the `pagination.nextToken` field returned in the `GetQueriesResponse` object.
		/// All other parameters must be provided with the same values that were provided with the request that generated
		/// this token, with the exception of `pageSize` which can be modified between calls to `getQueries`. In
		/// the absence of this token value, `getQueries` returns the first page of results.
		/// </summary>
		[InQuery("paginationToken")]
		public string PaginationToken { get; set; }
	}
}
