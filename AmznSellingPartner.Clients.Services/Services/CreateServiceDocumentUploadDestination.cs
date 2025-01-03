namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `createServiceDocumentUploadDestination` operation.
	/// </summary>
	public class CreateServiceDocumentUploadDestination : BaseClass
	{
		[JsonProperty("payload")]
		public ServiceDocumentUploadDestination Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
