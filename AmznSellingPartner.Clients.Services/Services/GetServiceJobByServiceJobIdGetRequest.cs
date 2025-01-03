namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/service/v1/serviceJobs/{serviceJobId}")]
	public class GetServiceJobByServiceJobIdGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A service job identifier.
		/// </summary>
		[InPath("serviceJobId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("serviceJobId")]
		public string ServiceJobId { get; set; }
	}
}
