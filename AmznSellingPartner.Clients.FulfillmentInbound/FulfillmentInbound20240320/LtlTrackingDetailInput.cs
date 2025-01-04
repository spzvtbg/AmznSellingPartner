namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains input information to update Less-Than-Truckload (LTL) tracking information.
	/// </summary>
	public class LtlTrackingDetailInput : BaseClass
	{
		/// <summary>
		/// The number of the carrier shipment acknowledgement document.
		/// </summary>
		[JsonProperty("billOfLadingNumber")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string BillOfLadingNumber { get; set; }

		/// <summary>
		/// Number associated with the freight bill.
		/// </summary>
		[JsonProperty("freightBillNumber")]
		[IsRequired]
		[MinItems(1)]
		[MaxItems(1)]
		public List<string> FreightBillNumber { get; set; }
	}
}
