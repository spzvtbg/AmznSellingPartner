namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// An unsigned integer that can be only positive or zero.
    /// </summary>
    [Minimum(0)]
    public class NonNegativeInteger : IntValue
    {
    }
}
