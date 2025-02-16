namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// A list of items contained in the package.
    /// </summary>
    [MaxItems(500)]
    public class Items : List<Item>
    {
    }
}
