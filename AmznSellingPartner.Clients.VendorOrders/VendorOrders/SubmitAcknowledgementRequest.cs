namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the submitAcknowledgment operation.
	/// </summary>
	public class SubmitAcknowledgementRequest : BaseClass
	{
		/// <summary>
		/// An array of order acknowledgements to be submitted.
		/// </summary>
		[JsonProperty("acknowledgements")]
		public List<OrderAcknowledgement> Acknowledgements { get; set; }
	}
}
