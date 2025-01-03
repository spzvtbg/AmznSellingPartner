namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/service/v1/serviceJobs/{serviceJobId}/appointments")]
	public class AddAppointmentForServiceJobByServiceJobIdPostRequest : BaseHttpRequest
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
		/// Add appointment operation input details
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public AddAppointmentRequest Body { get; set; }
	}
}
