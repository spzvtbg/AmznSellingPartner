namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    /// <summary>
    /// The weight of the package.
    /// </summary>
    [Minimum(11)]
    public class WeightValue : IntValue
    {
    }
}
