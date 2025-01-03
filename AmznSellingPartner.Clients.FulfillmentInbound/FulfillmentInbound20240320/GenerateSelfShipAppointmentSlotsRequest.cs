namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The `generateSelfShipAppointmentSlots` request.
	/// </summary>
	public class GenerateSelfShipAppointmentSlotsRequest : BaseClass
	{
		/// <summary>
		/// The desired end date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.
		/// </summary>
		[JsonProperty("desiredEndDate")]
		public DateTime DesiredEndDate { get; set; }

		/// <summary>
		/// The desired start date. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime format.
		/// </summary>
		[JsonProperty("desiredStartDate")]
		public DateTime DesiredStartDate { get; set; }
	}
}
