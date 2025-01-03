namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/easyShip/2022-03-23/package")]
	public class GetScheduledPackageGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon-defined order identifier. Identifies the order that the seller wants to deliver using Amazon
		/// Easy Ship.
		/// </summary>
		[InQuery("amazonOrderId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(255)]
		[JsonProperty("amazonOrderId")]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// An identifier for the marketplace in which the seller is selling.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(255)]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }
	}
}
