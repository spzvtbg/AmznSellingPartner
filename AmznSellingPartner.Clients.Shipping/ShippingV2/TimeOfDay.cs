namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Denotes time of the day, used for defining opening or closing time of access points
	/// </summary>
	public class TimeOfDay : BaseClass
	{
		[JsonProperty("hourOfDay")]
		public int HourOfDay { get; set; }

		[JsonProperty("minuteOfHour")]
		public int MinuteOfHour { get; set; }

		[JsonProperty("secondOfMinute")]
		public int SecondOfMinute { get; set; }
	}
}
