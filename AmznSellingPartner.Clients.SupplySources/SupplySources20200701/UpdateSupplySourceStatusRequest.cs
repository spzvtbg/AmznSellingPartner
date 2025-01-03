namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// A request to update the status of a supply source.
	/// </summary>
	public class UpdateSupplySourceStatusRequest : BaseClass
	{
		[JsonProperty("status")]
		public SupplySourceStatus Status { get; set; }
	}
}
