namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
    using Newtonsoft.Json;

    /// <summary>
    /// Item identifier and serial number information.
    /// </summary>
    public class Item : BaseClass
    {
        [JsonProperty("orderItemId")]
        public OrderItemId OrderItemId { get; set; }

        [JsonProperty("orderItemSerialNumbers")]
        public OrderItemSerialNumbers OrderItemSerialNumbers { get; set; }
    }
}
