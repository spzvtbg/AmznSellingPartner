namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `updateScheduledPackages` operation.
	/// </summary>
	public class UpdateScheduledPackagesRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public String MarketplaceId { get; set; }

		[IsRequired]
		[JsonProperty("updatePackageDetailsList")]
		public UpdatePackageDetailsList UpdatePackageDetailsList { get; set; }
	}
}
