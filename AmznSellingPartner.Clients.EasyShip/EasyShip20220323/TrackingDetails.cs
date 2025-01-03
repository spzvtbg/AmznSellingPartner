namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using Newtonsoft.Json;

	/// <summary>
	/// Representation of tracking metadata.
	/// </summary>
	public class TrackingDetails : BaseClass
	{
		/// <summary>
		/// The tracking identifier for the scheduled package.
		/// </summary>
		[JsonProperty("trackingId")]
		public String TrackingId { get; set; }
	}
}
