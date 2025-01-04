namespace AmznSellingPartner
{
    using AmznSellingPartner.BuildTools;

    class Program
    {
        static void Main()
        {
            AmznBuildTools.Build();

            //var awdUri = new Uri("http://localhost", UriKind.Absolute);
            //var awdClient = new AwdClient(awdUri);

            ////var inboundShipment = await awdClient.GetInboundShipmentAsync(new GetInboundShipmentGetRequest
            ////{
            ////    ShipmentId = "amzn.awd.TestShipmentId.0000001",
            ////    SkuQuantities = SkuQuantities.SHOW
            ////});

            //var inboundShipments = await awdClient.ListInboundShipmentsAsync(new ListInboundShipmentsGetRequest
            //{
            //    UpdatedAfter = DateTime.Now,
            //    MaxResults = 100,
            //    NextToken = "dfasdüfkasdökf",
            //    ShipmentStatus = ShipmentStatus.SHIPPED,
            //    SortBy = SortBy.UPDATED_AT,
            //    SortOrder = SortOrder.ASCENDING,
            //    UpdatedBefore = DateTime.Now,
            //});
        }
    }
}
