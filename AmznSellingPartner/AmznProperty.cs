namespace AmznSellingPartner
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;

    internal class AmznProperty : AmznUnhandled
    {
        public string Type { get; set; }

        public string Format { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public bool? IsRequired { get; set; }

        internal virtual CsProperty OnDeserialized(string name, CsType @class, CsContext context)
        {
            var property = new CsProperty { Name = name }
                .HasDescription(this.Description);

            if (this.IsRequired is not null)
            {
                property.HasAttribute(nameof(IsRequired));
            }

            return property;
        }
    }

    internal class AmznPropertyBoolean : AmznProperty
    {
        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context) 
              => base.OnDeserialized(name, @class, context)
                     .HasType("bool");
    }

    internal class AmznPropertyInt : AmznProperty
    {
        public int? Minimum { get; set; }

        public int? Maximum { get; set; }

        // TODO: Implement Multiple of property
        public int? MultipleOf { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
        {
            var property = base.OnDeserialized(name, @class, context)
                               .HasType("int");

            if (this.Minimum is not null)
            {
                property.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            if (this.Maximum is not null)
            {
                property.HasAttribute(nameof(this.Maximum), this.Maximum);
            }

            return property;
        }
    }

    internal class AmznPropertyLong : AmznProperty
    {
        public long? Minimum { get; set; }

        public long? Maximum { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
        {
            var property = base.OnDeserialized(name, @class, context)
                               .HasType("long");

            if (this.Minimum is not null)
            {
                property.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            if (this.Maximum is not null)
            {
                property.HasAttribute(nameof(this.Maximum), this.Maximum);
            }

            return property;
        }
    }

    internal class AmznPropertyFloat : AmznProperty
    {
        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
              => base.OnDeserialized(name, @class, context)
                     .HasType("float");
    }

    internal class AmznPropertyDouble : AmznProperty
    {
        public double? Minimum { get; set; }

        public double? Maximum { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
        {
            var property = base.OnDeserialized(name, @class, context)
                               .HasType("double");

            if (this.Minimum is not null)
            {
                property.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            if (this.Maximum is not null)
            {
                property.HasAttribute(nameof(this.Maximum), this.Maximum);
            }

            return property;
        }
    }

    internal class AmznPropertyRef : AmznProperty
    {
        public string Ref { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
              => base.OnDeserialized(name, @class, context)
                     .HasType(this.Ref.GetReferenceType());
    }

    internal class AmznPropertyAdditional : AmznProperty
    {
        public AmznAdditionalProperties AdditionalProperties { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
              => base.OnDeserialized(name, @class, context)
                     .HasType(new AmznDefinitionObject
                     {
                         AdditionalProperties = this.AdditionalProperties
                     }
                     .OnDeserialized(name, context)
                     .GetTypeName());
    }

    internal class AmznPropertyObject : AmznProperty
    {
        public string[] Required { get; set; }

        public AmznProperties Properties { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
              => base.OnDeserialized(name, @class, context)
                     .HasType(new AmznDefinitionObject
                     {
                         Required = this.Required,
                         Properties = this.Properties,
                     }
                     .OnDeserialized(name, context)
                     .GetTypeName());
    }

    internal class AmznPropertyString : AmznProperty
    {
        public string Pattern { get; set; }

        public string Default { get; set; }

        public string Example { get; set; }

        public int? MinLength { get; set; }

        public int? MaxLength { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
        {
            var property = base.OnDeserialized(name, @class, context)
                               .HasType("string");

            if (this.Pattern is not null)
            {
                property.HasAttribute(nameof(this.Pattern), $"\"{this.Pattern}\"");
            }

            if (this.MinLength is not null)
            {
                property.HasAttribute(nameof(this.MinLength), this.MinLength);
            }

            if (this.MaxLength is not null)
            {
                property.HasAttribute(nameof(this.MaxLength), this.MaxLength);
            }

            if (this.Default is not null)
            {
                property.HasDefaultValue($"\"{this.Default}\"");
            }

            return property;
        }
    }

    internal class AmznPropertyEnum : AmznProperty
    {
        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public AmznEnum[] EnumDefinitions { get; set; }

        public string Example { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context) 
              => base.OnDeserialized(name, @class, context)
                     .HasType(new AmznDefinitionEnum
                     {
                         Enum = this.Enum,
                         EnumDefinitions = this.EnumDefinitions,
                     }
                     .OnDeserialized(name, context)
                     .GetTypeName());
    }

    internal class AmznPropertyDateTime : AmznProperty
    {
        public string Example { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
              => base.OnDeserialized(name, @class, context)
                     .HasType(nameof(DateTime), "System");
    }

    internal class AmznPropertyArray : AmznProperty
    {
        public int? MinLength { get; set; }

        public int? MaxLength { get; set; }

        public int? MinItems { get; set; }

        public int? MaxItems { get; set; }

        public bool? UniqueItems { get; set; }

        public AmznPropertyItem Items { get; set; }

        public JToken Example { get; set; }

        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
        {
            var item = this.Items.OnDeserialized(name, context);
            var property = base.OnDeserialized(name, @class, context)
                               .HasType($"List<{item.Type}>", "System.Collections.Generic");

            if (this.MinLength is not null)
            {
                property.HasAttribute(nameof(this.MinLength), this.MinLength);
            }

            if (this.MaxLength is not null)
            {
                property.HasAttribute(nameof(this.MaxLength), this.MaxLength);
            }

            if (this.MinItems is not null)
            {
                property.HasAttribute(nameof(this.MinItems), this.MinItems);
            }

            if (this.MaxItems is not null)
            {
                property.HasAttribute(nameof(this.MaxItems), this.MaxItems);
            }

            if (this.UniqueItems == true)
            {
                property.HasAttribute(nameof(this.UniqueItems), null);
            }

            return property;
        }
    }

    internal class AmznPropertyUndefined : AmznProperty
    {
        internal override CsProperty OnDeserialized(string name, CsType @class, CsContext context)
              => base.OnDeserialized(name, @class, context)
                     .HasType("undefined");
    }
}