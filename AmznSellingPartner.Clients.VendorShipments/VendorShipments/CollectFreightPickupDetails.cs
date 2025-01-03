namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Transport Request pickup date from Vendor Warehouse by Buyer
	/// </summary>
	public class CollectFreightPickupDetails : BaseClass
	{
		/// <summary>
		/// Date on which the items can be picked up from vendor warehouse by Buyer used for WePay/Collect vendors.
		/// </summary>
		[JsonProperty("requestedPickUp")]
		public DateTime RequestedPickUp { get; set; }

		/// <summary>
		/// Date on which the items are scheduled to be picked from vendor warehouse by Buyer used for WePay/Collect vendo
		/// s.
		/// </summary>
		[JsonProperty("scheduledPickUp")]
		public DateTime ScheduledPickUp { get; set; }

		/// <summary>
		/// Date on which the carrier is being scheduled to pickup items from vendor warehouse by Byer used for WePay/Coll
		/// ct vendors.
		/// </summary>
		[JsonProperty("carrierAssignmentDate")]
		public DateTime CarrierAssignmentDate { get; set; }
	}
}
