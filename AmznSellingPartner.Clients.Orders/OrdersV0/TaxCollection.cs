namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Information about withheld taxes.
	/// </summary>
	public class TaxCollection : BaseClass
	{
		/// <summary>
		/// The tax collection model applied to the item.
		/// </summary>
		[JsonProperty("Model")]
		public Model Model { get; set; } 

		/// <summary>
		/// The party responsible for withholding the taxes and remitting them to the taxing authority.
		/// </summary>
		[JsonProperty("ResponsibleParty")]
		public ResponsibleParty ResponsibleParty { get; set; } 
	}
}
