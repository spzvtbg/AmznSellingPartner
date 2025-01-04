namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum Locale
	{
		/// <summary>
		/// Default locale of the requested Amazon marketplace.
		/// </summary>
		[EnumMember(Value = "DEFAULT")]
		DEFAULT,

		/// <summary>
		/// Arabic
		/// </summary>
		[EnumMember(Value = "ar")]
		Ar,

		/// <summary>
		/// Arabic (U.A.E.)
		/// </summary>
		[EnumMember(Value = "ar_AE")]
		Ar_AE,

		/// <summary>
		/// German
		/// </summary>
		[EnumMember(Value = "de")]
		De,

		/// <summary>
		/// German (Germany)
		/// </summary>
		[EnumMember(Value = "de_DE")]
		De_DE,

		/// <summary>
		/// English
		/// </summary>
		[EnumMember(Value = "en")]
		En,

		/// <summary>
		/// English (U.A.E.)
		/// </summary>
		[EnumMember(Value = "en_AE")]
		En_AE,

		/// <summary>
		/// English (Australia)
		/// </summary>
		[EnumMember(Value = "en_AU")]
		En_AU,

		/// <summary>
		/// English (Canada)
		/// </summary>
		[EnumMember(Value = "en_CA")]
		En_CA,

		/// <summary>
		/// English (United Kingdom)
		/// </summary>
		[EnumMember(Value = "en_GB")]
		En_GB,

		/// <summary>
		/// English (India)
		/// </summary>
		[EnumMember(Value = "en_IN")]
		En_IN,

		/// <summary>
		/// English (Singapore)
		/// </summary>
		[EnumMember(Value = "en_SG")]
		En_SG,

		/// <summary>
		/// English (United States)
		/// </summary>
		[EnumMember(Value = "en_US")]
		En_US,

		/// <summary>
		/// Spanish
		/// </summary>
		[EnumMember(Value = "es")]
		Es,

		/// <summary>
		/// Spanish (Spain)
		/// </summary>
		[EnumMember(Value = "es_ES")]
		Es_ES,

		/// <summary>
		/// Spanish (Mexico)
		/// </summary>
		[EnumMember(Value = "es_MX")]
		Es_MX,

		/// <summary>
		/// Spanish (United States)
		/// </summary>
		[EnumMember(Value = "es_US")]
		Es_US,

		/// <summary>
		/// French
		/// </summary>
		[EnumMember(Value = "fr")]
		Fr,

		/// <summary>
		/// French (Canada)
		/// </summary>
		[EnumMember(Value = "fr_CA")]
		Fr_CA,

		/// <summary>
		/// French (France)
		/// </summary>
		[EnumMember(Value = "fr_FR")]
		Fr_FR,

		/// <summary>
		/// Italian
		/// </summary>
		[EnumMember(Value = "it")]
		It,

		/// <summary>
		/// Italian (Italy)
		/// </summary>
		[EnumMember(Value = "it_IT")]
		It_IT,

		/// <summary>
		/// Japanese
		/// </summary>
		[EnumMember(Value = "ja")]
		Ja,

		/// <summary>
		/// Japanese (Japan)
		/// </summary>
		[EnumMember(Value = "ja_JP")]
		Ja_JP,

		/// <summary>
		/// Dutch
		/// </summary>
		[EnumMember(Value = "nl")]
		Nl,

		/// <summary>
		/// Dutch (Netherlands)
		/// </summary>
		[EnumMember(Value = "nl_NL")]
		Nl_NL,

		/// <summary>
		/// Polish
		/// </summary>
		[EnumMember(Value = "pl")]
		Pl,

		/// <summary>
		/// Polish (Poland)
		/// </summary>
		[EnumMember(Value = "pl_PL")]
		Pl_PL,

		/// <summary>
		/// Portuguese
		/// </summary>
		[EnumMember(Value = "pt")]
		Pt,

		/// <summary>
		/// Portuguese (Brazil)
		/// </summary>
		[EnumMember(Value = "pt_BR")]
		Pt_BR,

		/// <summary>
		/// Portuguese (Portugal)
		/// </summary>
		[EnumMember(Value = "pt_PT")]
		Pt_PT,

		/// <summary>
		/// Swedish
		/// </summary>
		[EnumMember(Value = "sv")]
		Sv,

		/// <summary>
		/// Swedish (Sweden)
		/// </summary>
		[EnumMember(Value = "sv_SE")]
		Sv_SE,

		/// <summary>
		/// Turkish
		/// </summary>
		[EnumMember(Value = "tr")]
		Tr,

		/// <summary>
		/// Turkish (Turkey)
		/// </summary>
		[EnumMember(Value = "tr_TR")]
		Tr_TR,

		/// <summary>
		/// Chinese
		/// </summary>
		[EnumMember(Value = "zh")]
		Zh,

		/// <summary>
		/// Chinese (Simplified)
		/// </summary>
		[EnumMember(Value = "zh_CN")]
		Zh_CN,

		/// <summary>
		/// Chinese (Traditional)
		/// </summary>
		[EnumMember(Value = "zh_TW")]
		Zh_TW,
	}
}
