namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A validation constraint.
	/// </summary>
	public class Constraint : BaseClass
	{
		/// <summary>
		/// A regular expression.
		/// </summary>
		[JsonProperty("ValidationRegEx")]
		public string ValidationRegEx { get; set; } 

		/// <summary>
		/// A validation string.
		/// </summary>
		[JsonProperty("ValidationString")]
		[IsRequired]
		public string ValidationString { get; set; } 
	}
}
