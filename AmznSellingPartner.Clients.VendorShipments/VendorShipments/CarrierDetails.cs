namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// Indicates the carrier details and their contact informations
	/// </summary>
	public class CarrierDetails : BaseClass
	{
		/// <summary>
		/// The field is used to represent the carrier used for performing the shipment.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; } 

		/// <summary>
		/// Code that identifies the carrier for the shipment. The Standard Carrier Alpha Code (SCAC) is
		/// a unique two to four letter code used to identify a carrier. Carrier SCAC codes are assigned
		/// and maintained by the NMFTA (National Motor Freight Association).
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; } 

		/// <summary>
		/// The field is used to represent the Carrier contact number.
		/// </summary>
		[JsonProperty("phone")]
		public string Phone { get; set; } 

		/// <summary>
		/// The field is used to represent the carrier Email id.
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; } 

		/// <summary>
		/// The field is also known as PRO number is a unique number assigned by the carrier. It is used
		/// to identify and track the shipment that goes out for delivery. This field is mandatory for
		/// US, CA, MX shipment confirmations.
		/// </summary>
		[JsonProperty("shipmentReferenceNumber")]
		public string ShipmentReferenceNumber { get; set; } 
	}
}
