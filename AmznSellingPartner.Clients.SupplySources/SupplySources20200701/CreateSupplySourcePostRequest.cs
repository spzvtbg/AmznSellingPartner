namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/supplySources/2020-07-01/supplySources")]
	public class CreateSupplySourcePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// A request to create a supply source
		/// </summary>
		[InBody("payload")]
		[IsRequired]
		[JsonProperty("payload")]
		public CreateSupplySourceRequest Payload { get; set; }
	}
}
