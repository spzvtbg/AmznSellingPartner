namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Access point details
	/// </summary>
	public class AccessPoint : BaseClass
	{
		[JsonProperty("accessPointId")]
		public AccessPointId AccessPointId { get; set; } 

		/// <summary>
		/// Name of entity (store/hub etc) where this access point is located
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; } 

		/// <summary>
		/// Timezone of access point
		/// </summary>
		[JsonProperty("timezone")]
		public string Timezone { get; set; } 

		[JsonProperty("type")]
		public AccessPointType Type { get; set; } 

		[JsonProperty("accessibilityAttributes")]
		public AccessibilityAttributes AccessibilityAttributes { get; set; } 

		[JsonProperty("address")]
		public Address Address { get; set; } 

		[JsonProperty("exceptionOperatingHours")]
		public List<ExceptionOperatingHours> ExceptionOperatingHours { get; set; } 

		[JsonProperty("assistanceType")]
		public AssistanceType AssistanceType { get; set; } 

		/// <summary>
		/// The score of access point, based on proximity to postal code and sorting preference. This can be used
		/// to sort access point results on shipper's end.
		/// </summary>
		[JsonProperty("score")]
		public string Score { get; set; } 

		[JsonProperty("standardOperatingHours")]
		public DayOfWeekTimeMap StandardOperatingHours { get; set; } 
	}
}
