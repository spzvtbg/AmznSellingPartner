namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// A page token that is returned when the results of the call exceed the page size. To get another
    /// page of results, call the operation again, passing in this value with the pageToken parame
    /// ter.
    /// </summary>
    [MinLength(1)]
    public class PageToken : StringValue
    {
    }
}
