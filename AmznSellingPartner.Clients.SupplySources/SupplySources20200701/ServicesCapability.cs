namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The services capability of a supply source.
	/// </summary>
	public class ServicesCapability : BaseClass
	{
		/// <summary>
		/// When true, `SupplySource` supports the Service capability.
		/// </summary>
		[JsonProperty("isSupported")]
		public bool IsSupported { get; set; } 

		[JsonProperty("operationalConfiguration")]
		public OperationalConfiguration OperationalConfiguration { get; set; } 
	}
}
