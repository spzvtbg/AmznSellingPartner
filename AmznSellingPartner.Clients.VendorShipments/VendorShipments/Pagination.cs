namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	/// <summary>
	/// The pagination elements required to retrieve the remaining data.
	/// </summary>
	public class Pagination : BaseClass
	{
		/// <summary>
		/// A generated string used to pass information to your next request. If NextToken is returned, pass the value of
		/// extToken to the next request. If NextToken is not returned, there are no more shipment items to return.
		/// </summary>
		[JsonProperty("nextToken")]
		public string NextToken { get; set; }
	}
}
