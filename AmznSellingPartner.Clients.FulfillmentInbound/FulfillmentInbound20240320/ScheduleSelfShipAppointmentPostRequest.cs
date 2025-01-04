namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/selfShipAppointmentSlots/{slotId}/schedule")]
	public class ScheduleSelfShipAppointmentPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// Identifier of an inbound plan.
		/// </summary>
		[InPath("inboundPlanId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		public string InboundPlanId { get; set; }

		/// <summary>
		/// Identifier of a shipment. A shipment contains the boxes and units being inbounded.
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		public string ShipmentId { get; set; }

		/// <summary>
		/// An identifier to a self-ship appointment slot.
		/// </summary>
		[InPath("slotId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		public string SlotId { get; set; }

		/// <summary>
		/// The body of the request to `scheduleSelfShipAppointment`.
		/// </summary>
		[InBody("body")]
		[IsRequired]
		public ScheduleSelfShipAppointmentRequest Body { get; set; }
	}
}
