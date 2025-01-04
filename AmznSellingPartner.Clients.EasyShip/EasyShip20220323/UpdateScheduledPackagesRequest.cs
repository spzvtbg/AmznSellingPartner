namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `updateScheduledPackages` operation.
	/// </summary>
	public class UpdateScheduledPackagesRequest : BaseClass
	{
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public String MarketplaceId { get; set; }

		[JsonProperty("updatePackageDetailsList")]
		[IsRequired]
		public UpdatePackageDetailsList UpdatePackageDetailsList { get; set; }
	}
}
