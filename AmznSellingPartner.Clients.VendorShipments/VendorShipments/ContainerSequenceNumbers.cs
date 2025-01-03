namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Container sequence numbers that are involved in this shipment.
	/// </summary>
	public class ContainerSequenceNumbers : BaseClass
	{
		/// <summary>
		/// A list of containers shipped
		/// </summary>
		[JsonProperty("containerSequenceNumber")]
		public string ContainerSequenceNumber { get; set; }
	}
}
