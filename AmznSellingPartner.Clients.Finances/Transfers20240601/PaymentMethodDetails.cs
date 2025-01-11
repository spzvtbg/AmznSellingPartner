namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using Newtonsoft.Json;

	/// <summary>
	/// The details of a payment method.
	/// </summary>
	public class PaymentMethodDetails : BaseClass
	{
		/// <summary>
		/// The name of the account holder who is registered for the payment method.
		/// </summary>
		[JsonProperty("accountHolderName")]
		public string AccountHolderName { get; set; } 

		/// <summary>
		/// The payment method identifier.
		/// </summary>
		[JsonProperty("paymentMethodId")]
		public string PaymentMethodId { get; set; } 

		/// <summary>
		/// The last three or four digits of the payment method.
		/// </summary>
		[JsonProperty("tail")]
		public string Tail { get; set; } 

		/// <summary>
		/// The expiration date of the card used for payment.
		/// </summary>
		[JsonProperty("expiryDate")]
		public ExpiryDate ExpiryDate { get; set; } 

		/// <summary>
		/// The two-letter country code in ISO 3166-1 alpha-2 format. For payment methods in the `card`
		/// category, the code is for the country where the card was issued. For payment methods in the
		/// `bank account` category, the code is for the country where the account is located.
		/// </summary>
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; } 

		/// <summary>
		/// The payment method type.
		/// </summary>
		[JsonProperty("paymentMethodType")]
		public PaymentMethodType PaymentMethodType { get; set; } 

		/// <summary>
		/// The payment method assignment type, whether it is assigned as default to the given marketplace
		/// or not.
		/// </summary>
		[JsonProperty("assignmentType")]
		public AssignmentType AssignmentType { get; set; } 
	}
}
