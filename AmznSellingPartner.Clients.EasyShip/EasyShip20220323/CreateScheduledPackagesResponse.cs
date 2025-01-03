namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The response schema for the bulk scheduling API
	/// It returns by the bulk scheduling API containing an array of the scheduled packtages, an optional list of ord
	/// rs we couldn't schedule with the reason, and a pre-signed URL for a ZIP file containing the associated shippin
	/// labels plus the documents enabled for your marketplace
	/// </summary>
	public class CreateScheduledPackagesResponse : BaseClass
	{
		/// <summary>
		/// A list of packages
		/// Refer to the `Package` object
		/// </summary>
		[MaxItems(100)]
		[JsonProperty("scheduledPackages")]
		public List<Package> ScheduledPackages { get; set; }

		/// <summary>
		/// A list of orders we couldn't scheduled on your behalf
		/// Each element contains the reason and details on the error
		/// </summary>
		[JsonProperty("rejectedOrders")]
		public List<RejectedOrder> RejectedOrders { get; set; }

		[JsonProperty("printableDocumentsUrl")]
		public URL PrintableDocumentsUrl { get; set; }
	}
}
