namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The Response  for the GenerateCollectionFormResponse operation.
	/// </summary>
	public class GenerateCollectionFormResponse : BaseClass
	{
		[JsonProperty("collectionsFormDocument")]
		public CollectionsFormDocument CollectionsFormDocument { get; set; } 
	}
}
