namespace AmznSellingPartner.Clients.Notifications.Notifications
{
    using System.Collections.Generic;

    /// <summary>
    /// A list of order change types to subscribe to (for example: `BuyerRequestedChange`). To receive
    /// notifications of all change types, do not provide this list.
    /// </summary>
    public class OrderChangeTypes : List<OrderChangeTypeEnum>
    {
    }
}
