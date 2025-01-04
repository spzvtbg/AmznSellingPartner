namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;

    using System;

    internal class AmznDefinitionItemConverter : AmznConverter<AmznDefinitionItem>
    {
        public override object ReadJson(JsonReader reader, Type _, object value, JsonSerializer _1)
        {
            var jobject = JObject.Load(reader);
            var jstring = jobject?.ToString();
            var type = jobject["type"]?.ToString();

            if (jobject["properties"] is not null)
            {
                value = Deserialize<AmznDefinitionItemProeprties>(jstring);
            }
            else if (jobject["ref"] is not null)
            {
                value = Deserialize<AmznDefinitionItemRef>(jstring);
            }
            else if (type == "string")
            {
                value = Deserialize<AmznDefinitionItemString>(jstring);
            }
            else if (type == "object")
            {
                value = Deserialize<AmznDefinitionItemString>(jstring);
            }
            else
            {
                this.NotifyUnhandledData(jobject);
            }

            return value;
        }
    }
}
