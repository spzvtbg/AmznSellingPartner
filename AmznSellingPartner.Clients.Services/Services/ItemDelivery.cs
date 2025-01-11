namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	/// <summary>
	/// Delivery information for the item.
	/// </summary>
	public class ItemDelivery : BaseClass
	{
		/// <summary>
		/// The date and time of the latest Estimated Delivery Date (EDD) of all the items with an EDD.
		/// In ISO 8601 format.
		/// </summary>
		[JsonProperty("estimatedDeliveryDate")]
		public DateTimeValue EstimatedDeliveryDate { get; set; } 

		/// <summary>
		/// Promised delivery information for the item.
		/// </summary>
		[JsonProperty("itemDeliveryPromise")]
		public ItemDeliveryPromise ItemDeliveryPromise { get; set; } 
	}
}
