namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Rich text content.
	/// </summary>
	public class TextComponent : BaseClass
	{
		/// <summary>
		/// The actual plain text.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(10000)]
		[JsonProperty("value")]
		public string Value { get; set; }

		[JsonProperty("decoratorSet")]
		public DecoratorSet DecoratorSet { get; set; }
	}
}
