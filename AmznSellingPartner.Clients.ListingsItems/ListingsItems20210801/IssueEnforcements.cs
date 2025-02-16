namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// This field provides information about the enforcement actions taken by Amazon that affect the
    /// publishing or status of a listing. It also includes details about any associated exemption
    /// s.
    /// </summary>
    public class IssueEnforcements : BaseClass
    {
        /// <summary>
        /// List of enforcement actions taken by Amazon that affect the publishing or status of a list
        /// ing.
        /// </summary>
        [JsonProperty("actions")]
        [IsRequired]
        public List<IssueEnforcementAction> Actions { get; set; }

        /// <summary>
        /// The "exemption" field serves to convey the status of enforcement actions by Amazon.
        /// </summary>
        [JsonProperty("exemption")]
        [IsRequired]
        public IssueExemption Exemption { get; set; }
    }
}
