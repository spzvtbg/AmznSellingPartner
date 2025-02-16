namespace AmznSellingPartner.Clients.Services.Services
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/service/v1/documents")]
    public class AmznCreateServiceDocumentUploadDestinationRequest : BaseHttpRequest
    {
        /// <summary>
        /// Upload document operation input details.
        /// </summary>
        [InBody("body")]
        [IsRequired]
        public ServiceUploadDocument Body { get; set; }
    }
}
