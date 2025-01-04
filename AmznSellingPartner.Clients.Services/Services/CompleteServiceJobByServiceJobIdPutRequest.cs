namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPut("/service/v1/serviceJobs/{serviceJobId}/completions")]
	public class CompleteServiceJobByServiceJobIdPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon defined service job identifier.
		/// </summary>
		[InPath("serviceJobId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string ServiceJobId { get; set; } 
	}
}
