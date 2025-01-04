namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	[HttpGet("/finances/transfers/2024-06-01/paymentMethods")]
	public class GetPaymentMethodsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// The identifier of the marketplace from which you want to retrieve payment methods. For the list of possible
		/// marketplace identifiers, refer to [Marketplace IDs](https://developer-docs.amazon.com/sp-api/docs/ma
		/// rketplace-ids).
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// A comma-separated list of the payment method types you want to include in the response.
		/// </summary>
		[InQuery("paymentMethodTypes")]
		[MinItems(1)]
		[UniqueItems]
		public CsvValue<PaymentMethodTypes> PaymentMethodTypes { get; set; } 
	}
}
