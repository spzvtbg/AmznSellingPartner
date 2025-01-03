namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The destination for the delivery offer
	/// </summary>
	public class Destination : BaseClass
	{
		[JsonProperty("deliveryAddress")]
		public VariablePrecisionAddress DeliveryAddress { get; set; }

		/// <summary>
		/// The IP address of the customer
		/// </summary>
		[JsonProperty("ipAddress")]
		public IpAddress IpAddress { get; set; }
	}
}
