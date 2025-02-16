namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// A unique reference key for the A+ Content document. A content reference key cannot form a permalink
    /// and may change in the future. A content reference key is not guaranteed to match any A+ content
    /// identifier.
    /// </summary>
    [MinLength(1)]
    public class ContentReferenceKey : StringValue
    {
    }
}
