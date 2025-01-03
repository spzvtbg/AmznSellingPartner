namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains information related to Less-Than-Truckload (LTL) shipment tracking
	/// </summary>
	public class LtlTrackingDetail : BaseClass
	{
		/// <summary>
		/// The number of the carrier shipment acknowledgement document
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("billOfLadingNumber")]
		public string BillOfLadingNumber { get; set; }

		/// <summary>
		/// The number associated with the freight bill
		/// </summary>
		[JsonProperty("freightBillNumber")]
		public List<string> FreightBillNumber { get; set; }
	}
}
