namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the createWarranty operation.
	/// </summary>
	public class CreateWarrantyRequest : BaseClass
	{
		/// <summary>
		/// Attachments to include in the message to the buyer. If any text is included in the attachment, the text must b
		/// written in the buyer's language of preference, which can be retrieved from the GetAttributes operation.
		/// </summary>
		[MinLength(1)]
		[MaxLength(5)]
		[JsonProperty("attachments")]
		public List<Attachment> Attachments { get; set; }

		/// <summary>
		/// The start date of the warranty coverage to include in the message to the buyer.
		/// </summary>
		[JsonProperty("coverageStartDate")]
		public DateTime CoverageStartDate { get; set; }

		/// <summary>
		/// The end date of the warranty coverage to include in the message to the buyer.
		/// </summary>
		[JsonProperty("coverageEndDate")]
		public DateTime CoverageEndDate { get; set; }
	}
}
