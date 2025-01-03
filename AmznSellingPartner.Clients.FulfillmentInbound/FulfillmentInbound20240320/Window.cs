namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Contains a start and end DateTime representing a time range
	/// </summary>
	public class Window : BaseClass
	{
		/// <summary>
		/// The timestamp at which this Window can no longer be edited
		/// </summary>
		[JsonProperty("editableUntil")]
		public DateTime EditableUntil { get; set; }

		/// <summary>
		/// The end timestamp of the window
		/// </summary>
		[IsRequired]
		[JsonProperty("end")]
		public DateTime End { get; set; }

		/// <summary>
		/// The start timestamp of the window
		/// </summary>
		[IsRequired]
		[JsonProperty("start")]
		public DateTime Start { get; set; }
	}
}
