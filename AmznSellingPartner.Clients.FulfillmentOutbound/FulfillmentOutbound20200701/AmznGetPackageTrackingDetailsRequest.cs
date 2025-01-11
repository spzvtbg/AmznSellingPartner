namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpGet("/fba/outbound/2020-07-01/tracking")]
	public class AmznGetPackageTrackingDetailsRequest : BaseHttpRequest
	{
		/// <summary>
		/// The unencrypted package identifier returned by the `getFulfillmentOrder` operation.
		/// </summary>
		[InQuery("packageNumber")]
		[IsRequired]
		public int PackageNumber { get; set; } 
	}
}
