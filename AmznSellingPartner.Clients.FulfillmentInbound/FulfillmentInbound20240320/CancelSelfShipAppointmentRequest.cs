namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	/// <summary>
	/// The `cancelSelfShipAppointment` request.
	/// </summary>
	public class CancelSelfShipAppointmentRequest : BaseClass
	{
		[JsonProperty("reasonComment")]
		public ReasonComment ReasonComment { get; set; }
	}
}
