namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/messaging/v1/orders/{amazonOrderId}/attributes")]
	public class AmznGetAttributesRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon order identifier. This identifies the order for which a message is sent.
		/// </summary>
		[InPath("amazonOrderId")]
		[IsRequired]
		public string AmazonOrderId { get; set; } 

		/// <summary>
		/// A marketplace identifier. This identifies the marketplace in which the order was placed. You
		/// can only specify one marketplace.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 
	}
}
