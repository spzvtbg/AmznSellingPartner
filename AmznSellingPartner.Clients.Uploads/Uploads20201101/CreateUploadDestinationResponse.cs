namespace AmznSellingPartner.Clients.Uploads.Uploads20201101
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the createUploadDestination operation.
	/// </summary>
	public class CreateUploadDestinationResponse : BaseClass
	{
		[JsonProperty("payload")]
		public UploadDestination Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
