namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/messaging/v1/orders/{amazonOrderId}")]
	public class GetMessagingActionsForOrderGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon order identifier. This specifies the order for which you want a list of available message
		/// types.
		/// </summary>
		[InPath("amazonOrderId")]
		[IsRequired]
		public string AmazonOrderId { get; set; }

		/// <summary>
		/// A marketplace identifier. This identifies the marketplace in which the order was placed. You can only
		/// specify one marketplace.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; }
	}
}
