namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A order which we couldn't schedule on your behalf. It contains its id, and information on the
	/// error.
	/// </summary>
	public class RejectedOrder : BaseClass
	{
		[JsonProperty("amazonOrderId")]
		[IsRequired]
		public AmazonOrderId AmazonOrderId { get; set; } 

		[JsonProperty("error")]
		public Error Error { get; set; } 
	}
}
