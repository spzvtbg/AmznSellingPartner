namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// ValidationMetadata Details
	/// </summary>
	public class ValidationMetadata : BaseClass
	{
		/// <summary>
		/// errorMessage for the error.
		/// </summary>
		[JsonProperty("errorMessage")]
		public string ErrorMessage { get; set; }

		/// <summary>
		/// validationStrategy for the error.
		/// </summary>
		[JsonProperty("validationStrategy")]
		public string ValidationStrategy { get; set; }

		/// <summary>
		/// Value.
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
