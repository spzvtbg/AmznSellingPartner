namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The address or reference to another `supplySourceId` to act as a return location
	/// </summary>
	public class ReturnLocation : BaseClass
	{
		/// <summary>
		/// The Amazon provided `supplySourceId` where orders can be returned to
		/// </summary>
		[JsonProperty("supplySourceId")]
		public string SupplySourceId { get; set; }

		[JsonProperty("addressWithContact")]
		public AddressWithContact AddressWithContact { get; set; }
	}
}
