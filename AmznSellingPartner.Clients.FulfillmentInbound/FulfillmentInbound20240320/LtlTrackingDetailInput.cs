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
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("billOfLadingNumber")]
		public string BillOfLadingNumber { get; set; }

		/// <summary>
		/// Number associated with the freight bill.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[MaxItems(1)]
		[JsonProperty("freightBillNumber")]
		public List<string> FreightBillNumber { get; set; }
	}
}
