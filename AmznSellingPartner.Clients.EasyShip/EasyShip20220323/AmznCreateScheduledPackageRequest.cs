namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/easyShip/2022-03-23/package")]
    public class AmznCreateScheduledPackageRequest : BaseHttpRequest
    {
        /// <summary>
        /// The request schema for the `createScheduledPackage` operation.
        /// </summary>
        [InBody("CreateScheduledPackageRequest")]
        [IsRequired]
        public CreateScheduledPackageRequest CreateScheduledPackageRequest { get; set; }
    }
}
