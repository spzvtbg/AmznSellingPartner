namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpPost("/supplySources/2020-07-01/supplySources")]
    public class AmznCreateSupplySourceRequest : BaseHttpRequest
    {
        /// <summary>
        /// A request to create a supply source.
        /// </summary>
        [InBody("payload")]
        [IsRequired]
        public CreateSupplySourceRequest Payload { get; set; }
    }
}
