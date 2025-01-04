namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/service/v1/serviceJobs")]
	public class GetServiceJobsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// List of service order ids for the query you want to perform.Max values supported 20.
		/// </summary>
		[InQuery("serviceOrderIds")]
		[MinItems(1)]
		[MaxItems(20)]
		public CsvValue<string> ServiceOrderIds { get; set; }

		/// <summary>
		/// A list of one or more job status by which to filter the list of jobs.
		/// </summary>
		[InQuery("serviceJobStatus")]
		public CsvValue<ServiceJobStatus> ServiceJobStatus { get; set; }

		/// <summary>
		/// String returned in the response of your previous request.
		/// </summary>
		[InQuery("pageToken")]
		public string PageToken { get; set; }

		/// <summary>
		/// A non-negative integer that indicates the maximum number of jobs to return in the list, Value must be
		/// 1 - 20. Default 20.
		/// </summary>
		[InQuery("pageSize")]
		[Minimum(1)]
		[Maximum(20)]
		public int PageSize { get; set; }

		/// <summary>
		/// Sort fields on which you want to sort the output.
		/// </summary>
		[InQuery("sortField")]
		public SortField SortField { get; set; }

		/// <summary>
		/// Sort order for the query you want to perform.
		/// </summary>
		[InQuery("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// A date used for selecting jobs created at or after a specified time. Must be in ISO 8601 format. Required
		/// if `LastUpdatedAfter` is not specified. Specifying both `CreatedAfter` and `LastUpdatedAfter` returns
		/// an error.
		/// </summary>
		[InQuery("createdAfter")]
		public string CreatedAfter { get; set; }

		/// <summary>
		/// A date used for selecting jobs created at or before a specified time. Must be in ISO 8601 format.
		/// </summary>
		[InQuery("createdBefore")]
		public string CreatedBefore { get; set; }

		/// <summary>
		/// A date used for selecting jobs updated at or after a specified time. Must be in ISO 8601 format. Required
		/// if `createdAfter` is not specified. Specifying both `CreatedAfter` and `LastUpdatedAfter` returns an
		/// error.
		/// </summary>
		[InQuery("lastUpdatedAfter")]
		public string LastUpdatedAfter { get; set; }

		/// <summary>
		/// A date used for selecting jobs updated at or before a specified time. Must be in ISO 8601 format.
		/// </summary>
		[InQuery("lastUpdatedBefore")]
		public string LastUpdatedBefore { get; set; }

		/// <summary>
		/// A date used for filtering jobs schedules at or after a specified time. Must be in ISO 8601 format. Schedule
		/// end date should not be earlier than schedule start date.
		/// </summary>
		[InQuery("scheduleStartDate")]
		public string ScheduleStartDate { get; set; }

		/// <summary>
		/// A date used for filtering jobs schedules at or before a specified time. Must be in ISO 8601 format. Schedule
		/// end date should not be earlier than schedule start date.
		/// </summary>
		[InQuery("scheduleEndDate")]
		public string ScheduleEndDate { get; set; }

		/// <summary>
		/// Used to select jobs that were placed in the specified marketplaces.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// List of Amazon Standard Identification Numbers (ASIN) of the items. Max values supported is 20.
		/// </summary>
		[InQuery("asins")]
		[MinItems(1)]
		[MaxItems(20)]
		public CsvValue<string> Asins { get; set; }

		/// <summary>
		/// A defined set of related knowledge, skills, experience, tools, materials, and work processes common to
		/// service delivery for a set of products and/or service scenarios. Max values supported is 20.
		/// </summary>
		[InQuery("requiredSkills")]
		[MinItems(1)]
		[MaxItems(20)]
		public CsvValue<string> RequiredSkills { get; set; }

		/// <summary>
		/// List of Amazon-defined identifiers for the region scope. Max values supported is 50.
		/// </summary>
		[InQuery("storeIds")]
		[MinItems(1)]
		[MaxItems(50)]
		public CsvValue<string> StoreIds { get; set; }
	}
}
