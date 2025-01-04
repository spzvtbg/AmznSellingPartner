namespace AmznSellingPartner.BuildTools
{
    using System.Collections.Generic;
    using System.IO;

    internal class CsContext : Dictionary<string, CsType>
    {
        internal IEnumerable<KeyValuePair<string, string>> GetClassList(string ns, string dir)
        {
            foreach (var cls in this.Values)
            {
                var key = Path.Combine(dir, $"{cls.GetTypeName()}.cs");
                var value = cls.ToString(ns, this);

                yield return new KeyValuePair<string, string>(key, value);
            }
        }

        internal CsClass GetOrCreateClass(string name)
        {
            name = name.Capitalize();
            var key = name.ToLower();

            if (!this.TryGetValue(key, out var csType))
            {
                this[key] = new CsClass(name);

                csType = this[key];
            }

            return csType as CsClass;
        }

        internal CsClient GetOrCreateClient(string name)
        {
            name = $"{name.Capitalize()}Client";
            var key = name.ToLower();

            if (!this.TryGetValue(key, out var csType))
            {
                this[key] = new CsClient(name);

                csType = this[key];
            }

            return csType as CsClient;
        }

        internal CsEnum GetOrCreateEnum(string name)
        {
            name = name.Capitalize();
            var key = name.ToLower();

            if (!this.TryGetValue(key, out var csType))
            {
                this[key] = new CsEnum(name);

                csType = this[key];
            }

            return csType as CsEnum;
        }
    }
}
