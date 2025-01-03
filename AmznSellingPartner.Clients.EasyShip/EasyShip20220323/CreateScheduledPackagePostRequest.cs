namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpPost("/easyShip/2022-03-23/package")]
	public class CreateScheduledPackagePostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `createScheduledPackage` operation
		/// </summary>
		[InBody("CreateScheduledPackageRequest")]
		[IsRequired]
		[JsonProperty("CreateScheduledPackageRequest")]
		public CreateScheduledPackageRequest CreateScheduledPackageRequest { get; set; }
	}
}
