namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPut("/service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId}/fulfillment")]
	public class SetAppointmentFulfillmentDataPutRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon-defined service job identifier. Get this value by calling the `getServiceJobs` operation of
		/// the Services API.
		/// </summary>
		[InPath("serviceJobId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string ServiceJobId { get; set; } 

		/// <summary>
		/// An Amazon-defined identifier of active service job appointment.
		/// </summary>
		[InPath("appointmentId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string AppointmentId { get; set; } 

		/// <summary>
		/// Appointment fulfillment data collection details.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public SetAppointmentFulfillmentDataRequest Body { get; set; } 
	}
}
