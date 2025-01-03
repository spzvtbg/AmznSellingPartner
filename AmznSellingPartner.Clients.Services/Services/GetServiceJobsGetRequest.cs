namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/service/v1/serviceJobs")]
	public class GetServiceJobsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// List of service order ids for the query you want to perform.Max values supported 20.
		/// </summary>
		[InQuery("serviceOrderIds")]
		[MinItems(1)]
		[MaxItems(20)]
		[JsonProperty("serviceOrderIds")]
		public CsvValue<string> ServiceOrderIds { get; set; }

		/// <summary>
		/// A list of one or more job status by which to filter the list of jobs.
		/// </summary>
		[InQuery("serviceJobStatus")]
		[JsonProperty("serviceJobStatus")]
		public CsvValue<ServiceJobStatus> ServiceJobStatus { get; set; }

		/// <summary>
		/// String returned in the response of your previous request.
		/// </summary>
		[InQuery("pageToken")]
		[JsonProperty("pageToken")]
		public string PageToken { get; set; }

		/// <summary>
		/// A non-negative integer that indicates the maximum number of jobs to return in the list, Value must be 1 - 20.
		/// efault 20.
		/// </summary>
		[InQuery("pageSize")]
		[Minimum(1)]
		[Maximum(20)]
		[JsonProperty("pageSize")]
		public int PageSize { get; set; }

		/// <summary>
		/// Sort fields on which you want to sort the output.
		/// </summary>
		[InQuery("sortField")]
		[JsonProperty("sortField")]
		public SortField SortField { get; set; }

		/// <summary>
		/// Sort order for the query you want to perform.
		/// </summary>
		[InQuery("sortOrder")]
		[JsonProperty("sortOrder")]
		public SortOrder SortOrder { get; set; }

		/// <summary>
		/// A date used for selecting jobs created at or after a specified time. Must be in ISO 8601 format. Required if `
		/// astUpdatedAfter` is not specified. Specifying both `CreatedAfter` and `LastUpdatedAfter` returns an error.
		/// </summary>
		[InQuery("createdAfter")]
		[JsonProperty("createdAfter")]
		public string CreatedAfter { get; set; }

		/// <summary>
		/// A date used for selecting jobs created at or before a specified time. Must be in ISO 8601 format.
		/// </summary>
		[InQuery("createdBefore")]
		[JsonProperty("createdBefore")]
		public string CreatedBefore { get; set; }

		/// <summary>
		/// A date used for selecting jobs updated at or after a specified time. Must be in ISO 8601 format. Required if `
		/// reatedAfter` is not specified. Specifying both `CreatedAfter` and `LastUpdatedAfter` returns an error.
		/// </summary>
		[InQuery("lastUpdatedAfter")]
		[JsonProperty("lastUpdatedAfter")]
		public string LastUpdatedAfter { get; set; }

		/// <summary>
		/// A date used for selecting jobs updated at or before a specified time. Must be in ISO 8601 format.
		/// </summary>
		[InQuery("lastUpdatedBefore")]
		[JsonProperty("lastUpdatedBefore")]
		public string LastUpdatedBefore { get; set; }

		/// <summary>
		/// A date used for filtering jobs schedules at or after a specified time. Must be in ISO 8601 format. Schedule en
		/// date should not be earlier than schedule start date.
		/// </summary>
		[InQuery("scheduleStartDate")]
		[JsonProperty("scheduleStartDate")]
		public string ScheduleStartDate { get; set; }

		/// <summary>
		/// A date used for filtering jobs schedules at or before a specified time. Must be in ISO 8601 format. Schedule e
		/// d date should not be earlier than schedule start date.
		/// </summary>
		[InQuery("scheduleEndDate")]
		[JsonProperty("scheduleEndDate")]
		public string ScheduleEndDate { get; set; }

		/// <summary>
		/// Used to select jobs that were placed in the specified marketplaces.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }

		/// <summary>
		/// List of Amazon Standard Identification Numbers (ASIN) of the items. Max values supported is 20.
		/// </summary>
		[InQuery("asins")]
		[MinItems(1)]
		[MaxItems(20)]
		[JsonProperty("asins")]
		public CsvValue<string> Asins { get; set; }

		/// <summary>
		/// A defined set of related knowledge, skills, experience, tools, materials, and work processes common to service
		/// delivery for a set of products and/or service scenarios. Max values supported is 20.
		/// </summary>
		[InQuery("requiredSkills")]
		[MinItems(1)]
		[MaxItems(20)]
		[JsonProperty("requiredSkills")]
		public CsvValue<string> RequiredSkills { get; set; }

		/// <summary>
		/// List of Amazon-defined identifiers for the region scope. Max values supported is 50.
		/// </summary>
		[InQuery("storeIds")]
		[MinItems(1)]
		[MaxItems(50)]
		[JsonProperty("storeIds")]
		public CsvValue<string> StoreIds { get; set; }
	}
}
