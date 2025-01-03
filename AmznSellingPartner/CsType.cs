namespace AmznSellingPartner
{
    using Newtonsoft.Json;

    using System.Collections.Generic;

    internal class CsType(string name)
    {
        [JsonProperty]
        protected Dictionary<string, string> attributes = [];

        [JsonProperty]
        protected ICollection<string> includes = [];

        [JsonProperty]
        protected Dictionary<string, string> members = [];

        [JsonProperty]
        protected Dictionary<string, CsProperty> properties = [];

        [JsonProperty]
        protected ICollection<string> usings = [];

        [JsonProperty]
        protected string description;

        [JsonProperty]
        protected string inherits;

        [JsonProperty]
        protected string name = name;

        internal string GetTypeName() => this.name;

        internal CsType HasAttribute(string name, object value)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.attributes[name] = value?.ToString();
                this.usings.Add("AmznSellingPartner.Clients.Attributes");
            }

            return this;
        }

        internal CsType HasMember(string member, string description = default)
        {
            if (!string.IsNullOrWhiteSpace(member))
            {
                this.members[member] = description;
            }

            return this;
        }

        internal CsType HasProperty(CsProperty property)
        {
            if (property.Name.Capitalize() == this.name)
            {
                if (char.IsLower(property.Name[0]))
                {
                    property.Name = $"{property.Name}Value";
                }
                else if (property.Name.StartsWith("List"))
                {
                    property.Name = $"{property.Name}List";
                }
                else
                {
                    property.Name = property.Type;
                }
            }

            this.properties[property.Name.ToLower()] = property;

            return this;
        }

        internal CsType HasSummary(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                this.description = description;
            }

            return this;
        }

        internal CsType Includes(string reference)
        {
            if (!string.IsNullOrWhiteSpace(reference))
            {
                this.includes.Add(reference);
            }

            return this;
        }

        internal CsType Inherits(string @base, string @using = default)
        {
            if (!string.IsNullOrWhiteSpace(@base))
            {
                this.inherits = @base;
            }

            if (!string.IsNullOrWhiteSpace(@using))
            {
                this.usings.Add(@using);
            }

            return this;
        }

        internal virtual string ToString(string ns, CsContext csContext) => this.name;
    }
}