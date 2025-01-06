namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Transport Request pickup date from Vendor Warehouse by Buyer
	/// </summary>
	public class CollectFreightPickupDetails : BaseClass
	{
		/// <summary>
		/// Date on which the items can be picked up from vendor warehouse by Buyer used for WePay/Collect vendo
		/// rs.
		/// </summary>
		[JsonProperty("requestedPickUp")]
		public DateTimeValue RequestedPickUp { get; set; } 

		/// <summary>
		/// Date on which the items are scheduled to be picked from vendor warehouse by Buyer used for WePay/Collect
		/// vendors.
		/// </summary>
		[JsonProperty("scheduledPickUp")]
		public DateTimeValue ScheduledPickUp { get; set; } 

		/// <summary>
		/// Date on which the carrier is being scheduled to pickup items from vendor warehouse by Byer used for WePay/Collect
		/// vendors.
		/// </summary>
		[JsonProperty("carrierAssignmentDate")]
		public DateTimeValue CarrierAssignmentDate { get; set; } 
	}
}
