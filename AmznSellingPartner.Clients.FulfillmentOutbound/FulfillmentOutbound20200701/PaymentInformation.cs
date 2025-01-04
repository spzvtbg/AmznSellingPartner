namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The attributes related to the payment made from customer to seller for this order.
	/// </summary>
	public class PaymentInformation : BaseClass
	{
		/// <summary>
		/// The transaction identifier of this payment.
		/// </summary>
		[JsonProperty("paymentTransactionId")]
		[IsRequired]
		public string PaymentTransactionId { get; set; } 

		/// <summary>
		/// The transaction mode of this payment.
		/// </summary>
		[JsonProperty("paymentMode")]
		[IsRequired]
		public string PaymentMode { get; set; } 

		/// <summary>
		/// The transaction date of this payment.
		/// </summary>
		[JsonProperty("paymentDate")]
		[IsRequired]
		public Timestamp PaymentDate { get; set; } 
	}
}
