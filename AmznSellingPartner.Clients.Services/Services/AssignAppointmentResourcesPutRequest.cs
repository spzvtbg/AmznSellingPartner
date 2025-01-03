namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPut("/service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId}/resources")]
	public class AssignAppointmentResourcesPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon-defined service job identifier. Get this value by calling the `getServiceJobs` operation of the Serv
		/// ces API.
		/// </summary>
		[InPath("serviceJobId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("serviceJobId")]
		public string ServiceJobId { get; set; }

		/// <summary>
		/// An Amazon-defined identifier of active service job appointment.
		/// </summary>
		[InPath("appointmentId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("appointmentId")]
		public string AppointmentId { get; set; }

		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public AssignAppointmentResourcesRequest Body { get; set; }
	}
}
