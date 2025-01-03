namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A return reason code, a description, and an optional description translation.
	/// </summary>
	public class ReasonCodeDetails : BaseClass
	{
		/// <summary>
		/// A code that indicates a valid return reason.
		/// </summary>
		[IsRequired]
		[JsonProperty("returnReasonCode")]
		public string ReturnReasonCode { get; set; }

		/// <summary>
		/// A human readable description of the return reason code.
		/// </summary>
		[IsRequired]
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// A translation of the description. The translation is in the language specified in the Language request
		/// parameter.
		/// </summary>
		[JsonProperty("translatedDescription")]
		public string TranslatedDescription { get; set; }
	}
}
