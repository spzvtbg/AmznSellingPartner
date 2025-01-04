namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Details of the innerContainersDetails.
	/// </summary>
	public class InnerContainersDetails : BaseClass
	{
		/// <summary>
		/// Total containers as part of the shipment
		/// </summary>
		[JsonProperty("containerCount")]
		public int ContainerCount { get; set; } 

		/// <summary>
		/// Container sequence numbers that are involved in this shipment.
		/// </summary>
		[JsonProperty("containerSequenceNumbers")]
		public List<ContainerSequenceNumbers> ContainerSequenceNumbers { get; set; } 
	}
}
