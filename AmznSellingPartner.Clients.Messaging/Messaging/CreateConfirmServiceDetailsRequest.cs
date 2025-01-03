namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the createConfirmServiceDetails operation.
	/// </summary>
	public class CreateConfirmServiceDetailsRequest : BaseClass
	{
		/// <summary>
		/// The text to be sent to the buyer. Only links related to Home Service calls are allowed. Do not include
		/// HTML or email addresses. The text must be written in the buyer's language of preference, which can be
		/// retrieved from the GetAttributes operation.
		/// </summary>
		[MinLength(1)]
		[MaxLength(2000)]
		[JsonProperty("text")]
		public string Text { get; set; }
	}
}
