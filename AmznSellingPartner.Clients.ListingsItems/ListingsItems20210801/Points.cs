namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The number of Amazon Points offered with the purchase of an item, and their monetary value.
	/// Note that the `Points` element is only returned in Japan (JP).
	/// </summary>
	public class Points : BaseClass
	{
		[JsonProperty("pointsNumber")]
		[IsRequired]
		public int PointsNumber { get; set; } 
	}
}
