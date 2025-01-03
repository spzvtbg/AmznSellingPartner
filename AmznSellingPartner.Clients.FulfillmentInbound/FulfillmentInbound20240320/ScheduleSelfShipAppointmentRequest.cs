namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	/// <summary>
	/// The `scheduleSelfShipAppointment` request
	/// </summary>
	public class ScheduleSelfShipAppointmentRequest : BaseClass
	{
		[JsonProperty("reasonComment")]
		public ReasonComment ReasonComment { get; set; }
	}
}
