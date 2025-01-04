namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The delivery preferences applied to the destination address. These preferences are applied when possible
	/// and are best effort. This feature is currently supported only in the JP marketplace and not applicable
	/// for other marketplaces. For eligible orders, the default delivery preference will be to deliver the package
	/// unattended at the front door, unless you specify otherwise.
	/// </summary>
	public class DeliveryPreferences : BaseClass
	{
		/// <summary>
		/// Additional delivery instructions. For example, this could be instructions on how to enter a building,
		/// nearby landmark or navigation instructions, 'Beware of dogs', etc.
		/// </summary>
		[JsonProperty("deliveryInstructions")]
		[MaxLength(250)]
		public string DeliveryInstructions { get; set; } 

		/// <summary>
		/// The preferred location to leave packages at the destination address.
		/// </summary>
		[JsonProperty("dropOffLocation")]
		public DropOffLocation DropOffLocation { get; set; } 
	}
}
