namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `listHandoverSlots` operation
	/// </summary>
	public class ListHandoverSlotsResponse : BaseClass
	{
		[IsRequired]
		[JsonProperty("amazonOrderId")]
		public AmazonOrderId AmazonOrderId { get; set; }

		[IsRequired]
		[JsonProperty("timeSlots")]
		public TimeSlots TimeSlots { get; set; }
	}
}
