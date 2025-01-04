namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/solicitations/v1/orders/{amazonOrderId}")]
	public class GetSolicitationActionsForOrderGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// An Amazon order identifier. This specifies the order for which you want a list of available solicitation
		/// types.
		/// </summary>
		[InPath("amazonOrderId")]
		[IsRequired]
		public string AmazonOrderId { get; set; } 

		/// <summary>
		/// A marketplace identifier. This specifies the marketplace in which the order was placed. Only one marketplace
		/// can be specified.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 
	}
}
