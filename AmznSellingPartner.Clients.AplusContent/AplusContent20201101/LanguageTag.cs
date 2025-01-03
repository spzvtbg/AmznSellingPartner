namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The IETF language tag. This only supports the primary language subtag with one secondary language subtag.
	/// The secondary language subtag is almost always a regional designation. This does not support additional
	/// subtags beyond the primary and secondary subtags. **Pattern:** ^[a-z]{2,}-[A-Z0-9]{2,}
	/// </summary>
	[MinLength(5)]
	public class LanguageTag : StringValue
	{
	}
}
