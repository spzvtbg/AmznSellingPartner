namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Freight information describes the skus being transported. Freight carrier options and quotes
	/// will only be returned if the freight information is provided.
	/// </summary>
	public class FreightInformation : BaseClass
	{
		[JsonProperty("declaredValue")]
		public Currency DeclaredValue { get; set; } 

		/// <summary>
		/// Freight class.  Possible values: `NONE`, `FC_50`, `FC_55`, `FC_60`, `FC_65`, `FC_70`, `FC_77_5`,
		/// `FC_85`, `FC_92_5`, `FC_100`, `FC_110`, `FC_125`, `FC_150`, `FC_175`, `FC_200`, `FC_250`, `FC_300`,
		/// `FC_400`, `FC_500`.
		/// </summary>
		[JsonProperty("freightClass")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string FreightClass { get; set; } 
	}
}
