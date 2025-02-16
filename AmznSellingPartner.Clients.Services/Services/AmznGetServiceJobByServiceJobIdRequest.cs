namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/service/v1/serviceJobs/{serviceJobId}")]
    public class AmznGetServiceJobByServiceJobIdRequest : BaseHttpRequest
    {
        /// <summary>
        /// A service job identifier.
        /// </summary>
        [InPath("serviceJobId")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(100)]
        public string ServiceJobId { get; set; }
    }
}
