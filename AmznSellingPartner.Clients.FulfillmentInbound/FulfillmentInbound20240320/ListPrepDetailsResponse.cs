namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The response to the `listPrepDetails` operation.
	/// </summary>
	public class ListPrepDetailsResponse : BaseClass
	{
		/// <summary>
		/// A list of MSKUs and related prep details.
		/// </summary>
		[IsRequired]
		[JsonProperty("mskuPrepDetails")]
		public List<MskuPrepDetail> MskuPrepDetails { get; set; }
	}
}
