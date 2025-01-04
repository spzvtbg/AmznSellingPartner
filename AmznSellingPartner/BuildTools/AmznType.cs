namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    internal class AmznType
    {
        [JsonProperty]
        protected string summary;

        public string Name { get; set; }
    }

    internal class AmznTypeClass : AmznType
    {
        [JsonProperty]
        private readonly Dictionary<string, AmznTypeProperty> properties = [];
        [JsonProperty]
        private readonly Dictionary<string, string> attributes = [];
        [JsonProperty]
        private string inherits;
        [JsonProperty]
        private string allOf;

        internal AmznTypeClass Inherits(string inherits)
        {
            this.inherits = inherits;

            return this;
        }

        internal AmznTypeClass AddSummary(string summary)
        {
            this.summary = $"{this.summary} {summary}";

            return this;
        }

        internal AmznTypeClass AddAttribute(string attribute)
        {
            this.attributes[attribute] = default;

            return this;
        }

        internal AmznTypeClass AddAttribute(string attribute, string value)
        {
            if (value is not null)
            {
                this.attributes[attribute] = value;
            }

            return this;
        }

        internal AmznTypeClass AddAllOf(string allOf)
        {
            this.allOf = allOf;

            return this;
        }

        internal AmznTypeClass AddMember(AmznTypeProperty property)
        {
            this.properties[$"{property.Name}"] = property;

            return this;
        }
    }

    internal class AmznTypeEnum : AmznType
    {
        [JsonProperty]
        private Dictionary<string, string> members = [];

        internal AmznTypeEnum AddMember(string key, string value = default)
        {
            this.members[key] = value;

            return this;
        }

        internal AmznTypeEnum AddSummary(string summary)
        {
            this.summary = $"{this.summary} {summary}";

            return this;
        }
    }
}