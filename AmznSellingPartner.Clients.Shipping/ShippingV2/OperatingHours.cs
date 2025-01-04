namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The hours in which the access point shall remain operational
	/// </summary>
	public class OperatingHours : BaseClass
	{
		[JsonProperty("closingTime")]
		public TimeOfDay ClosingTime { get; set; } 

		[JsonProperty("openingTime")]
		public TimeOfDay OpeningTime { get; set; } 

		[JsonProperty("midDayClosures")]
		public List<TimeOfDay> MidDayClosures { get; set; } 
	}
}
