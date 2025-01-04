namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json.Linq;

    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    internal class AmznModel
    {
        public static event Action<string, string, JToken> UnhandledData;

        private readonly CsContext context = [];

        public AmznPaths Paths { get; set; }

        public AmznDefinitions Definitions { get; set; }

        public AmznParameters Parameters { get; set; }

        internal IEnumerable<KeyValuePair<string, string>> GetClassList(string ns, string dir)
            => this.context.GetClassList(ns, dir);

        [OnDeserialized]
        private void OnDeserialized(StreamingContext _)
        {
            this.Definitions?.OnDeserialized(this.context);
            this.Paths?.OnDeserialized(this.context, this.Parameters);
        }

        public static void NotifyUnhandledData(string type, string field, JToken value)
            => UnhandledData?.Invoke(type, field, value);

        public static implicit operator CsContext(AmznModel model) => model?.context;
    }
}
