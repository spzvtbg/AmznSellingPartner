namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Defines the accessibility details of the access point.
	/// </summary>
	public class AccessibilityAttributes : BaseClass
	{
		/// <summary>
		/// The approximate distance of access point from input postalCode's centroid.
		/// </summary>
		[JsonProperty("distance")]
		public string Distance { get; set; } 

		/// <summary>
		/// The approximate (static) drive time from input postal code's centroid.
		/// </summary>
		[JsonProperty("driveTime")]
		public int DriveTime { get; set; } 
	}
}
