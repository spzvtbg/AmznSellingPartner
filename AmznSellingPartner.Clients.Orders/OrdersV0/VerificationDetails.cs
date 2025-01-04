namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Additional information related to the verification of a regulated order.
	/// </summary>
	public class VerificationDetails : BaseClass
	{
		/// <summary>
		/// Information regarding the prescription tied to the order.
		/// </summary>
		[JsonProperty("prescriptionDetail")]
		public PrescriptionDetail PrescriptionDetail { get; set; } 
	}
}
