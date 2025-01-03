namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents a file that was uploaded to a destination that was created by the Uploads API [`createUploadDestinationForResource`](https://developer-docs.amazon.com/sp-api/docs/uploads-api-reference#post-uploads2020-11-01uploaddestinationsresource)
	/// operation.
	/// </summary>
	public class Attachment : BaseClass
	{
		/// <summary>
		/// The identifier for the upload destination. To retrieve this value, call the Uploads API [`createUploadDestinationForResource`](https://developer-docs.amazon.com/sp-api/docs/uploads-api-reference#post-uploads2020-11-01uploaddestinationsresource)
		/// operation.
		/// </summary>
		[IsRequired]
		[JsonProperty("uploadDestinationId")]
		public string UploadDestinationId { get; set; }

		/// <summary>
		/// The name of the file, including the extension. This is the file name that will appear in the message.
		/// This does not need to match the file name of the file that you uploaded.
		/// </summary>
		[IsRequired]
		[JsonProperty("fileName")]
		public string FileName { get; set; }
	}
}
