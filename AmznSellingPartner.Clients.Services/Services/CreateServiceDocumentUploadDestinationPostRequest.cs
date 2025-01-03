namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/service/v1/documents")]
	public class CreateServiceDocumentUploadDestinationPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Upload document operation input details
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public ServiceUploadDocument Body { get; set; }
	}
}
