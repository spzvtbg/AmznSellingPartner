namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/dataKiosk/2023-11-15/queries")]
	public class CreateQueryPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The body of the request.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		[JsonProperty("body")]
		public CreateQuerySpecification Body { get; set; }
	}
}
