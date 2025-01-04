namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// This object allows users to specify an order to be scheduled. Only the amazonOrderId is required.
	/// </summary>
	public class OrderScheduleDetails : BaseClass
	{
		[JsonProperty("amazonOrderId")]
		[IsRequired]
		public AmazonOrderId AmazonOrderId { get; set; } 

		[JsonProperty("packageDetails")]
		public PackageDetails PackageDetails { get; set; } 
	}
}
