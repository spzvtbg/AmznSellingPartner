namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `createScheduledPackage` operation.
	/// </summary>
	public class CreateScheduledPackageRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("amazonOrderId")]
		public AmazonOrderId AmazonOrderId { get; set; }

		[IsRequired]
		[JsonProperty("marketplaceId")]
		public String MarketplaceId { get; set; }

		[IsRequired]
		[JsonProperty("packageDetails")]
		public PackageDetails PackageDetails { get; set; }
	}
}
