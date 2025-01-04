namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId}")]
	public class RescheduleAppointmentForServiceJobByServiceJobIdPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon defined service job identifier.
		/// </summary>
		[InPath("serviceJobId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string ServiceJobId { get; set; } 

		/// <summary>
		/// An existing appointment identifier for the Service Job.
		/// </summary>
		[InPath("appointmentId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string AppointmentId { get; set; } 

		/// <summary>
		/// Reschedule appointment operation input details.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public RescheduleAppointmentRequest Body { get; set; } 
	}
}
