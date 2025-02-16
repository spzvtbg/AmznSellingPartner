namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
    using AmznSellingPartner.Clients.HttpAttributes;
    using AmznSellingPartner.Clients.ValidationAttributes;

    [HttpGet("/dataKiosk/2023-11-15/queries/{queryId}")]
    public class AmznGetQueryRequest : BaseHttpRequest
    {
        /// <summary>
        /// The query identifier.
        /// </summary>
        [InPath("queryId")]
        [IsRequired]
        public string QueryId { get; set; }
    }
}
