namespace AmznSellingPartner
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;

    using System;

    internal class AmznAllOfConverter : AmznConverter<AmznAllOf>
    {
        public override object ReadJson(JsonReader reader, Type _, object value, JsonSerializer _1)
        {
            var jobject = JObject.Load(reader);
            var type = jobject["type"]?.ToString();
            var jstring = jobject?.ToString();

            if (type == "object")
            {
                value = Deserialize<AmznAllOfObject>(jstring);
            }
            else if (type is null)
            {
                value = Deserialize<AmznAllOfRef>(jstring);
            }
            else
            {
                this.NotifyUnhandledData(jobject);
            }

            return value;
        }
    }
}
