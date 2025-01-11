namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The delivery information for the package. This information is available after the package is
	/// delivered.
	/// </summary>
	public class DeliveryInformation : BaseClass
	{
		/// <summary>
		/// All of the delivery documents for a package.
		/// </summary>
		[JsonProperty("deliveryDocumentList")]
		public DeliveryDocumentList DeliveryDocumentList { get; set; } 

		/// <summary>
		/// The drop off location for a package.
		/// </summary>
		[JsonProperty("dropOffLocation")]
		public DropOffLocation DropOffLocation { get; set; } 
	}
}
