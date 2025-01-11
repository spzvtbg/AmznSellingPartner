namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using Newtonsoft.Json;

	/// <summary>
	/// The expiration date of the card used for payment. If the payment method is not `card`, the
	/// expiration date is `null`.
	/// </summary>
	public class ExpiryDate : BaseClass
	{
		/// <summary>
		/// The month the card expires expressed as a number from `1` to `12`.
		/// </summary>
		[JsonProperty("month")]
		public string Month { get; set; } 

		/// <summary>
		/// Year
		/// </summary>
		[JsonProperty("year")]
		public string Year { get; set; } 
	}
}
