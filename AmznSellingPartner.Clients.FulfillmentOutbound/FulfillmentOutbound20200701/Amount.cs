namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A quantity based on unit of measure
	/// </summary>
	public class Amount : BaseClass
	{
		/// <summary>
		/// The unit of measure for the amount
		/// </summary>
		[IsRequired]
		[JsonProperty("unitOfMeasure")]
		public UnitOfMeasure UnitOfMeasure { get; set; }

		/// <summary>
		/// The amount of a product in the associated unit of measure
		/// </summary>
		[IsRequired]
		[JsonProperty("value")]
		public Decimal Value { get; set; }
	}
}
