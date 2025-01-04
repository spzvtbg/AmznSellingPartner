namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Attribute Properties required by carrier
	/// </summary>
	public class CarrierAccountAttribute : BaseClass
	{
		/// <summary>
		/// Attribute Name .
		/// </summary>
		[JsonProperty("attributeName")]
		public string AttributeName { get; set; } 

		/// <summary>
		/// Property Group.
		/// </summary>
		[JsonProperty("propertyGroup")]
		public string PropertyGroup { get; set; } 

		/// <summary>
		/// Value .
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; } 
	}
}
