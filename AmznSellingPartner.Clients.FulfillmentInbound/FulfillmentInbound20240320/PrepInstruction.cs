namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Information pertaining to the preparation of inbound goods.
    /// </summary>
    public class PrepInstruction : BaseClass
    {
        [JsonProperty("fee")]
        public Currency Fee { get; set; }

        /// <summary>
        /// In some situations, special preparations are required for items and this field reflects the
        /// owner of the preparations. Options include `AMAZON`, `SELLER` or `NONE`.
        /// </summary>
        [JsonProperty("prepOwner")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string PrepOwner { get; set; }

        /// <summary>
        /// Type of preparation that should be done.  Possible values: `ITEM_LABELING`, `ITEM_BUBBLEWRAP`,
        /// `ITEM_POLYBAGGING`, `ITEM_TAPING`, `ITEM_BLACK_SHRINKWRAP`, `ITEM_HANG_GARMENT`, `ITEM_BOXING`,
        /// `ITEM_SETCREAT`, `ITEM_RMOVHANG`, `ITEM_SUFFOSTK`, `ITEM_CAP_SEALING`, `ITEM_DEBUNDLE`, `ITEM_SETSTK`,
        /// `ITEM_SIOC`, `ITEM_NO_PREP`, `ADULT`, `BABY`, `TEXTILE`, `HANGER`, `FRAGILE`, `LIQUID`, `SHARP`,
        /// `SMALL`, `PERFORATED`, `GRANULAR`, `SET`, `FC_PROVIDED`, `UNKNOWN`, `NONE`.
        /// </summary>
        [JsonProperty("prepType")]
        [MinLength(1)]
        [MaxLength(1024)]
        public string PrepType { get; set; }
    }
}
