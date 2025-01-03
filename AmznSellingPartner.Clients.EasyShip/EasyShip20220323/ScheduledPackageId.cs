namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Identifies the scheduled package to be updated
	/// </summary>
	public class ScheduledPackageId : BaseClass
	{
		[IsRequired]
		[JsonProperty("amazonOrderId")]
		public AmazonOrderId AmazonOrderId { get; set; }

		[JsonProperty("packageId")]
		public PackageId PackageId { get; set; }
	}
}
