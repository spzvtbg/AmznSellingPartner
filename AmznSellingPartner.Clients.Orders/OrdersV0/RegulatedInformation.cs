namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The regulated information collected during purchase and used to verify the order.
	/// </summary>
	public class RegulatedInformation : BaseClass
	{
		/// <summary>
		/// A list of regulated information fields as collected from the regulatory form.
		/// </summary>
		[JsonProperty("Fields")]
		[IsRequired]
		public List<RegulatedInformationField> Fields { get; set; } 
	}
}
