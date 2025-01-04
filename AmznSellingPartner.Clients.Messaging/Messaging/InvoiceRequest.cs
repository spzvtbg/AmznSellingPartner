namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the `sendInvoice` operation.
	/// </summary>
	public class InvoiceRequest : BaseClass
	{
		/// <summary>
		/// Attachments to include in the message to the buyer.
		/// </summary>
		[JsonProperty("attachments")]
		[MinLength(1)]
		[MaxLength(5)]
		public List<Attachment> Attachments { get; set; }
	}
}
