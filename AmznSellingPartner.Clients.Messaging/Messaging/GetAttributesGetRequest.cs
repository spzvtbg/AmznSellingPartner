namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	[HttpGet("/messaging/v1/orders/{amazonOrderId}/attributes")]
	public class GetAttributesGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon order identifier
		/// This identifies the order for which a message is sent
		/// </summary>
		[InPath("amazonOrderId")]
		[IsRequired]
		[JsonProperty("amazonOrderId")]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// A marketplace identifier
		/// This identifies the marketplace in which the order was placed
		/// You can only specify one marketplace
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		[JsonProperty("marketplaceIds")]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
