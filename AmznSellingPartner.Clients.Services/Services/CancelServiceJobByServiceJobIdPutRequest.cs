namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPut("/service/v1/serviceJobs/{serviceJobId}/cancellations")]
	public class CancelServiceJobByServiceJobIdPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon defined service job identifier
		/// </summary>
		[InPath("serviceJobId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("serviceJobId")]
		public string ServiceJobId { get; set; }

		/// <summary>
		/// A cancel reason code that specifies the reason for cancelling a service job
		/// </summary>
		[InQuery("cancellationReasonCode")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[Pattern("^[A-Z0-9_]*")]
		[JsonProperty("cancellationReasonCode")]
		public string CancellationReasonCode { get; set; }
	}
}
