namespace AmznSellingPartner.BuildTools
{
    using AmznSellingPartner;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;

    internal class AmznConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            Converters =
            {
                new AmznAllOfConverter(),
                new AmznDefinitionConverter(),
                new AmznDefinitionItemConverter(),
                new AmznParameterConverter(),
                new AmznParameterItemConverter(),
                new AmznPropertyConverter(),
                new AmznPropertyItemConverter(),
            }
        };
    }

    internal class AmznConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType)
            => objectType == typeof(T);

        public override object ReadJson(JsonReader reader, Type type, object value, JsonSerializer serializer)
            => value;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => writer.WriteValue(value);

        protected static X Deserialize<X>(string jstring)
            => JsonConvert.DeserializeObject<X>(jstring, AmznConverter.Settings);

        protected void NotifyUnhandledData(JObject jobject)
            => AmznModel.NotifyUnhandledData(this.GetType().Name, nameof(jobject), jobject);
    }
}
