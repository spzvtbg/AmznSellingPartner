namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/service/v1/serviceJobs/{serviceJobId}/appointments/{appointmentId}")]
    public class AmznRescheduleAppointmentForServiceJobByServiceJobIdRequest : BaseHttpRequest
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
