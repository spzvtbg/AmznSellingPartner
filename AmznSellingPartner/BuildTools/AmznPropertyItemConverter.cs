namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;

    using System;

    internal class AmznPropertyItemConverter : AmznConverter<AmznPropertyItem>
    {
        public override object ReadJson(JsonReader reader, Type _, object value, JsonSerializer _1)
        {
            var jobject = JObject.Load(reader);
            var jstring = jobject?.ToString();
            var type = jobject["type"]?.ToString();
            var format = jobject["format"]?.ToString();

            if (jobject["ref"] is not null)
            {
                value = Deserialize<AmznPropertyItemRef>(jstring);
            }
            else if (type == "integer")
            {
                if (format == "int64")
                {
                    value = Deserialize<AmznPropertyItemLong>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyItemInt>(jstring);
                }
            }
            else if (type == "number")
            {
                if (format == "int32")
                {
                    value = Deserialize<AmznPropertyItemInt>(jstring);
                }
                else if (format == "int64")
                {
                    value = Deserialize<AmznPropertyItemLong>(jstring);
                }
                else if (format == "float")
                {
                    value = Deserialize<AmznPropertyItemFloat>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyItemDouble>(jstring);
                }
            }
            else if (type == "object")
            {
                value = Deserialize<AmznPropertyItemObject>(jstring);
            }
            else if (type == "string")
            {
                if (jobject["x-docgen-enum-table-extension"] is not null)
                {
                    value = Deserialize<AmznPropertyItemEnum>(jstring);
                }
                else if (jobject["enum"] is not null)
                {
                    value = Deserialize<AmznPropertyItemEnum>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyItemString>(jstring);
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
