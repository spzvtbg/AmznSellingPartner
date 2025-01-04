namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `listHandoverSlots` operation.
	/// </summary>
	public class ListHandoverSlotsRequest : BaseClass
	{
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public String MarketplaceId { get; set; }

		[JsonProperty("amazonOrderId")]
		[IsRequired]
		public AmazonOrderId AmazonOrderId { get; set; }

		[JsonProperty("packageDimensions")]
		[IsRequired]
		public Dimensions PackageDimensions { get; set; }

		[JsonProperty("packageWeight")]
		[IsRequired]
		public Weight PackageWeight { get; set; }
	}
}
