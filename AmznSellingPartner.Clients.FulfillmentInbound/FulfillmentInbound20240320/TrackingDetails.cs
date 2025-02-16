namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using Newtonsoft.Json;

    /// <summary>
    /// Tracking information for Less-Than-Truckload (LTL) and Small Parcel Delivery (SPD) shipmen
    /// ts.
    /// </summary>
    public class TrackingDetails : BaseClass
    {
        [JsonProperty("ltlTrackingDetail")]
        public LtlTrackingDetail LtlTrackingDetail { get; set; }

        [JsonProperty("spdTrackingDetail")]
        public SpdTrackingDetail SpdTrackingDetail { get; set; }
    }
}
