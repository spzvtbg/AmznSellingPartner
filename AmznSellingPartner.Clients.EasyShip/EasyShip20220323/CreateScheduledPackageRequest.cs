namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The request schema for the `createScheduledPackage` operation.
    /// </summary>
    public class CreateScheduledPackageRequest : BaseClass
    {
        [JsonProperty("amazonOrderId")]
        [IsRequired]
        public AmazonOrderId AmazonOrderId { get; set; }

        [JsonProperty("marketplaceId")]
        [IsRequired]
        public String MarketplaceId { get; set; }

        [JsonProperty("packageDetails")]
        [IsRequired]
        public PackageDetails PackageDetails { get; set; }
    }
}
