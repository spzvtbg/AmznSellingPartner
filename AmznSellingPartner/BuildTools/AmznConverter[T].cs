namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;

    internal class AmznConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
            => objectType == typeof(T);

        public override object ReadJson(JsonReader reader, Type type, object value, JsonSerializer serializer)
            => value;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => writer.WriteValue(value);

        protected static X Deserialize<X>(string jstring)
            => JsonConvert.DeserializeObject<X>(jstring);

        protected void NotifyUnhandledData(JObject jobject)
            => AmznModel.NotifyUnhandledData(this.GetType().Name, nameof(jobject), jobject);
    }
}
