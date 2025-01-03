namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `listHandoverSlots` operation
	/// </summary>
	public class ListHandoverSlotsRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public String MarketplaceId { get; set; }

		[IsRequired]
		[JsonProperty("amazonOrderId")]
		public AmazonOrderId AmazonOrderId { get; set; }

		[IsRequired]
		[JsonProperty("packageDimensions")]
		public Dimensions PackageDimensions { get; set; }

		[IsRequired]
		[JsonProperty("packageWeight")]
		public Weight PackageWeight { get; set; }
	}
}
