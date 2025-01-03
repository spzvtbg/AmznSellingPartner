namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The A+ Content document subtype. This represents a special-purpose type of an A+ Content document. Not every A
	/// Content document type will have a subtype, and subtypes may change at any time.
	/// </summary>
	[MinLength(1)]
	public class ContentSubType : StringValue
	{
	}
}
