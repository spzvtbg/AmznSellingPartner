namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPut("/service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId}/resources")]
    public class AmznAssignAppointmentResourcesRequest : BaseHttpRequest
    {
        /// <summary>
        /// An Amazon-defined service job identifier. Get this value by calling the `getServiceJobs` operation
        /// of the Services API.
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

        [InBody("body")]
        [IsRequired]
        public AssignAppointmentResourcesRequest Body { get; set; }
    }
}
