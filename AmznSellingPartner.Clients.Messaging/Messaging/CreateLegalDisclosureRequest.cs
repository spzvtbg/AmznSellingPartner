namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the createLegalDisclosure operation
	/// </summary>
	public class CreateLegalDisclosureRequest : BaseClass
	{
		/// <summary>
		/// Attachments to include in the message to the buyer
		/// If any text is included in the attachment, the text must be written in the buyer's language of preference, wh
		/// ch can be retrieved from the GetAttributes operation
		/// </summary>
		[MaxLength(5)]
		[JsonProperty("attachments")]
		public List<Attachment> Attachments { get; set; }
	}
}
