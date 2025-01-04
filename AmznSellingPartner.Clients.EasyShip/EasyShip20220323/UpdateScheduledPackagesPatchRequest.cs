namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPatch("/easyShip/2022-03-23/package")]
	public class UpdateScheduledPackagesPatchRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `updateScheduledPackages` operation.
		/// </summary>
		[InBody("UpdateScheduledPackagesRequest")]
		public UpdateScheduledPackagesRequest UpdateScheduledPackagesRequest { get; set; }
	}
}
