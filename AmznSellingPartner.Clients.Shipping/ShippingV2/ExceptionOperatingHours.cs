namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Defines exceptions to standard operating hours for certain date ranges
	/// </summary>
	public class ExceptionOperatingHours : BaseClass
	{
		[JsonProperty("dateRange")]
		public DateRange DateRange { get; set; }

		[JsonProperty("operatingHours")]
		public OperatingHours OperatingHours { get; set; }
	}
}
