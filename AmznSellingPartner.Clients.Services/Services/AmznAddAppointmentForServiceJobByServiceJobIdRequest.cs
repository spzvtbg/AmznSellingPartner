namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/service/v1/serviceJobs/{serviceJobId}/appointments")]
    public class AmznAddAppointmentForServiceJobByServiceJobIdRequest : BaseHttpRequest
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
        /// Add appointment operation input details.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public AddAppointmentRequest Body { get; set; }
    }
}
