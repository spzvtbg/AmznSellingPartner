namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	public class GetAppointmmentSlotsByJobIdGetResponse : BaseHttpResponse<GetAppointmmentSlotsByJobIdGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success response.
		/// </summary>
		public GetAppointmentSlotsResponse GetAppointmentSlotsResponse { get; set; } 
	}
}
