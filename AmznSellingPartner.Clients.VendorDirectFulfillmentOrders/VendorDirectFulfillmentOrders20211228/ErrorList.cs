namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of error responses returned when a request is unsuccessful.
	/// </summary>
	public class ErrorList : BaseClass
	{
		/// <summary>
		/// An array of Error objects representing individual errors encountered during the request.
		/// </summary>
		[JsonProperty("errors")]
		[IsRequired]
		public List<Error> Errors { get; set; } 
	}
}
