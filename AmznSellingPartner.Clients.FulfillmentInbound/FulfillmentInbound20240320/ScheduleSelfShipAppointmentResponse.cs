namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `scheduleSelfShipAppointment` response.
	/// </summary>
	public class ScheduleSelfShipAppointmentResponse : BaseClass
	{
		[JsonProperty("selfShipAppointmentDetails")]
		[IsRequired]
		public SelfShipAppointmentDetails SelfShipAppointmentDetails { get; set; } 
	}
}
