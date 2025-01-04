namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Map of day of the week to operating hours of that day
	/// </summary>
	public class DayOfWeekTimeMap : BaseClass
	{
		[JsonProperty("")]
		public OperatingHours AdditionalValue { get; set; } 
	}
}
