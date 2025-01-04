namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains all of the delivery instructions provided by the customer for the shipping address.
	/// </summary>
	public class DeliveryPreferences : BaseClass
	{
		/// <summary>
		/// Drop-off location selected by the customer.
		/// </summary>
		[JsonProperty("DropOffLocation")]
		public string DropOffLocation { get; set; } 

		/// <summary>
		/// Business hours and days when the delivery is preferred.
		/// </summary>
		[JsonProperty("PreferredDeliveryTime")]
		public PreferredDeliveryTime PreferredDeliveryTime { get; set; } 

		/// <summary>
		/// Enumerated list of miscellaneous delivery attributes associated with the shipping address.
		/// </summary>
		[JsonProperty("OtherAttributes")]
		public List<OtherDeliveryAttributes> OtherAttributes { get; set; } 

		/// <summary>
		/// Building instructions, nearby landmark or navigation instructions.
		/// </summary>
		[JsonProperty("AddressInstructions")]
		public string AddressInstructions { get; set; } 
	}
}
