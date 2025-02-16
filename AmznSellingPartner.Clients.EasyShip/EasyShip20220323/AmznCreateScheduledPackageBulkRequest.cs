namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/easyShip/2022-03-23/packages/bulk")]
    public class AmznCreateScheduledPackageBulkRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request schema for the `createScheduledPackageBulk` operation.
        /// </summary>
        [InBody("CreateScheduledPackagesRequest")]
        [IsRequired]
        public CreateScheduledPackagesRequest CreateScheduledPackagesRequest { get; set; }
    }
}
