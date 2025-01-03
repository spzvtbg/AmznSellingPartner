namespace AmznSellingPartner
{
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class AmznDefinition : AmznUnhandled
    {
        public string Type { get; set; }

        public string Format { get; set; }

        public string Description { get; set; }

        public JToken Example { get; set; }

        [JsonProperty("x-example")]
        public JToken XExample { get; set; }

        internal virtual CsType OnDeserialized(string name, CsContext context) 
              => context.GetOrCreateClass(name)
                        .HasSummary(this.Description);
    }

    internal class AmznDefinitionString : AmznDefinition
    {
        public string Pattern { get; set; }

        public int? MinLength { get; set; }

        public int? MaxLength { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var @class = base.OnDeserialized(name, context)
                           .Inherits(nameof(StringValue), "AmznSellingPartner.Clients.Values");

            if (this.Pattern is not null)
            {
                @class.HasAttribute(nameof(this.Pattern), $"\"{this.Pattern}\"");
            }

            if (this.MinLength is not null)
            {
                @class.HasAttribute(nameof(this.MinLength), this.MinLength);
            }

            if (this.MaxLength is not null)
            {
                @class.HasAttribute(nameof(this.MaxLength), this.MaxLength);
            }

            return @class;
        }
    }

    internal class AmznDefinitionDateTime : AmznDefinition
    {
        internal override CsType OnDeserialized(string name, CsContext context) 
              => base.OnDeserialized(name, context)
                     .Inherits(nameof(DateTimeValue), "AmznSellingPartner.Clients.Values");
    }

    internal class AmznDefinitionIP : AmznDefinition
    {
        internal override CsType OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .Inherits(nameof(StringValue), "AmznSellingPartner.Clients.Values");
    }

    internal class AmznDefinitionBase64 : AmznDefinition
    {
        internal override CsType OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .Inherits(nameof(Base64Value), "AmznSellingPartner.Clients.Values");
    }

    internal class AmznDefinitionEnum : AmznDefinition
    {
        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public AmznEnum[] EnumDefinitions { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var @enum = context.GetOrCreateEnum(name)
                     ?? context.GetOrCreateEnum($"{name}s");

            @enum.HasSummary(this.Description);

            foreach (var member in this.Enum ?? [])
            {
                @enum.HasMember(member);
            }

            foreach (var member in this.EnumDefinitions ?? [])
            {
                @enum.HasMember(member.Value, member.Description);
            }

            return @enum;
        }
    }

    internal class AmznDefinitionAdditional : AmznDefinition
    {
        public AmznAdditionalProperties AdditionalProperties { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var @class = base.OnDeserialized(name, context);
            var property = this.AdditionalProperties.Property;
            property.Name = "AdditionalValue";

            @class.HasProperty(property);

            return @class;
        }
    }

    internal class AmznDefinitionObject : AmznDefinition
    {
        public AmznProperties Properties { get; set; }

        public string[] Required { get; set; }

        public AmznAdditionalProperties AdditionalProperties { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var @class = base.OnDeserialized(name, context);

            foreach (var proeprtyName in this.Required ?? [])
            {
                this.Properties.SetRequired(proeprtyName);
            }

            foreach (var (propertyName, propertyValue) in this.Properties ?? [])
            {
                var property = propertyValue.OnDeserialized(propertyName, @class, context);

                @class.HasProperty(property);
            }

            if (this.AdditionalProperties is not null)
            {
                var additionalProperty = this.AdditionalProperties.Property;
                additionalProperty.Name = "AdditionalValue";

                @class.HasProperty(additionalProperty);
            }

            return @class;
        }
    }

    internal class AmznDefinitionInt : AmznDefinition
    {
        public int? Minimum { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var type = base.OnDeserialized(name, context)
                           .Inherits(nameof(IntValue), "AmznSellingPartner.Clients.Values");

            if (this.Minimum is not null)
            {
                type.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            return type;
        }
    }

    internal class AmznDefinitionLong : AmznDefinition
    {
        internal override CsType OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .Inherits(nameof(LongValue), "AmznSellingPartner.Clients.Values");
    }

    internal class AmznDefinitionFloat : AmznDefinition
    {
        public float? Minimum { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var type = base.OnDeserialized(name, context)
                           .Inherits(nameof(IntValue), "AmznSellingPartner.Clients.Values");

            if (this.Minimum is not null)
            {
                type.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            return type;
        }
    }

    internal class AmznDefinitionDouble : AmznDefinition
    {
        internal override CsType OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .Inherits(nameof(DoubleValue), "AmznSellingPartner.Clients.Values");
    }

    internal class AmznDefinitionBoolean : AmznDefinition
    {
        internal override CsType OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .Inherits(nameof(BooleanValue), "AmznSellingPartner.Clients.Values");
    }

    internal class AmznDefinitionArray : AmznDefinition
    {
        public int? MinItems { get; set; }

        public int? MaxItems { get; set; }

        public bool? UniqueItems { get; set; }

        public AmznDefinitionItem Items { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var @class = base.OnDeserialized(name, context);
            var item = this.Items.OnDeserialized($"{name}Item", context);

            foreach (var (key, value) in item.GetAttributes())
            {
                @class.HasAttribute(key, value);
            }

            if (this.MinItems is not null)
            {
                @class.HasAttribute(nameof(this.MinItems), this.MinItems);
            }

            if (this.MaxItems is not null)
            {
                @class.HasAttribute(nameof(this.MaxItems), this.MaxItems);
            }

            if (this.UniqueItems == true)
            {
                @class.HasAttribute(nameof(this.UniqueItems), null);
            }

            return @class.Inherits($"List<{item.Type}>", "System.Collections.Generic");
        }
    }

    internal class AmznDefinitionUndefined : AmznDefinition
    {
        public AmznAllOf[] AllOf { get; set; }

        public AmznAdditionalProperties AdditionalProperties { get; set; }

        internal override CsType OnDeserialized(string name, CsContext context)
        {
            var @class = base.OnDeserialized(name, context) as CsClass;

            foreach (var allOf in this.AllOf ?? [])
            {
                foreach (var property in allOf.GetProperties(name, @class, context))
                {
                    @class.HasProperty(property);
                }

                @class.Includes(allOf.Reference);
            }

            return @class;
        }
    }
}