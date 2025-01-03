namespace AmznSellingPartner
{
    using Newtonsoft.Json;

    internal class AmznPropertyItem : AmznUnhandled
    {
        public string Type { get; set; }

        public string Format { get; set; }

        public string Description { get; set; }

        internal virtual CsProperty OnDeserialized(string name, CsContext context) 
              => new CsProperty().HasDescription(this.Description);
    }

    internal class AmznPropertyItemRef : AmznPropertyItem
    {
        public string Ref { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context) 
              => base.OnDeserialized(name, context)
                     .HasType(this.Ref.GetReferenceType());
    }

    internal class AmznPropertyItemInt : AmznPropertyItem
    {
        public int? Minimum { get; set; }

        public int? Maximum { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
        {
            var proeprty = base.OnDeserialized(name, context)
                               .HasType("int");

            if (this.Minimum is not null)
            {
                proeprty.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            if (this.Maximum is not null)
            {
                proeprty.HasAttribute(nameof(this.Maximum), this.Maximum);
            }

            return proeprty;
        }
    }

    internal class AmznPropertyItemLong : AmznPropertyItem
    {
        public long? Minimum { get; set; }

        public long? Maximum { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
        {
            var proeprty = base.OnDeserialized(name, context)
                               .HasType("long");

            if (this.Minimum is not null)
            {
                proeprty.HasAttribute(nameof(this.Minimum), this.Minimum);
            }

            if (this.Maximum is not null)
            {
                proeprty.HasAttribute(nameof(this.Maximum), this.Maximum);
            }

            return proeprty;
        }
    }

    internal class AmznPropertyItemFloat : AmznPropertyItem
    {
        internal override CsProperty OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .HasType("float");
    }

    internal class AmznPropertyItemDouble : AmznPropertyItem
    {
        internal override CsProperty OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .HasType("double");
    }

    internal class AmznPropertyItemObject : AmznPropertyItem
    {
        public AmznAdditionalProperties AdditionalProperties { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context) 
              => base.OnDeserialized(name, context)
                     .HasType(new AmznDefinitionObject
                     {
                         AdditionalProperties = this.AdditionalProperties
                     }
                     .OnDeserialized(name, context)
                     .GetTypeName());
    }

    internal class AmznPropertyItemString : AmznPropertyItem
    {
        public string Pattern { get; set; }

        public int? MinLength { get; set; }

        public int? MaxLength { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
        {
            var proeprty = base.OnDeserialized(name, context)
                               .HasType("string");

            if (this.MinLength is not null)
            {
                proeprty.HasAttribute(nameof(this.MinLength), this.MinLength);
            }

            if (this.MaxLength is not null)
            {
                proeprty.HasAttribute(nameof(this.MaxLength), this.MaxLength);
            }

            if (this.Pattern is not null)
            {
                proeprty.HasAttribute(nameof(this.Pattern), this.Pattern);
            }

            return proeprty;
        }
    }

    internal class AmznPropertyItemEnum : AmznPropertyItem
    {
        public string[] Enum { get; set; }

        [JsonProperty("x-docgen-enum-table-extension")]
        public AmznEnum[] EnumDefinitions { get; set; }

        internal override CsProperty OnDeserialized(string name, CsContext context)
              => base.OnDeserialized(name, context)
                     .HasType(new AmznDefinitionEnum
                     {
                         Enum = this.Enum,
                         EnumDefinitions = this.EnumDefinitions,
                     }
                     .OnDeserialized(name, context)
                     .GetTypeName());
    }
}