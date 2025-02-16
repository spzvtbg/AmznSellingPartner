namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Identifies the scheduled package to be updated.
    /// </summary>
    public class ScheduledPackageId : BaseClass
    {
        [JsonProperty("amazonOrderId")]
        [IsRequired]
        public AmazonOrderId AmazonOrderId { get; set; }

        [JsonProperty("packageId")]
        public PackageId PackageId { get; set; }
    }
}
