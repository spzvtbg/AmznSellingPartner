namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the confirmCustomizationDetails operation.
	/// </summary>
	public class CreateConfirmCustomizationDetailsRequest : BaseClass
	{
		/// <summary>
		/// The text to be sent to the buyer. Only links related to customization details are allowed. Do not include
		/// HTML or email addresses. The text must be written in the buyer's language of preference, which can be
		/// retrieved from the GetAttributes operation.
		/// </summary>
		[JsonProperty("text")]
		[MinLength(1)]
		[MaxLength(800)]
		public string Text { get; set; }

		/// <summary>
		/// Attachments to include in the message to the buyer.
		/// </summary>
		[JsonProperty("attachments")]
		[MaxLength(5)]
		public List<Attachment> Attachments { get; set; }
	}
}
