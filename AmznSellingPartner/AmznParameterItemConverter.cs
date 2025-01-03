namespace AmznSellingPartner
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;

    internal class AmznParameterItemConverter : AmznConverter<AmznParameterItem>
    {
        public override object ReadJson(JsonReader reader, Type _, object value, JsonSerializer _1)
        {
            var jobject = JObject.Load(reader);
            var jstring = jobject?.ToString();
            var type = jobject["type"]?.ToString();

            if (type == "string")
            {
                if (jobject["enum"] is not null)
                {
                    value = Deserialize<AmznParameterItemEnum>(jstring);
                }
                else
                {
                    value = Deserialize<AmznParameterItemString>(jstring);
                }
            }
            else
            {
                this.NotifyUnhandledData(jobject);
            }

            return value;
        }
    }
}
