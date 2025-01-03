namespace AmznSellingPartner
{
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;

    using System;

    internal class AmznPropertyConverter : AmznConverter<AmznProperty>
    {
        public override object ReadJson(JsonReader reader, Type _, object value, JsonSerializer _1)
        {
            var jobject = JObject.Load(reader);
            var jstring = jobject?.ToString();
            var type = jobject["type"]?.ToString();
            var format = jobject["format"]?.ToString();

            if (type == "object")
            {
                if (jobject["ref"] is not null)
                {
                    value = Deserialize<AmznPropertyRef>(jstring);
                }
                else if (jobject["additionalProperties"] is not null)
                {
                    value = Deserialize<AmznPropertyAdditional>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyObject>(jstring);
                }
            }
            else if (type == "string")
            {
                if (jobject["x-docgen-enum-table-extension"] is not null)
                {
                    value = Deserialize<AmznPropertyEnum>(jstring);
                }
                else if (jobject["enum"] is not null)
                {
                    value = Deserialize<AmznPropertyEnum>(jstring);
                }
                else if (format == "date-time" || format == "dateTime" || format == "date")
                {
                    value = Deserialize<AmznPropertyDateTime>(jstring);
                }
                else if (jobject["ref"] is not null)
                {
                    value = Deserialize<AmznPropertyRef>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyString>(jstring);
                }
            }
            else if (type == "integer")
            {
                if (format == "int64")
                {
                    value = Deserialize<AmznPropertyLong>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyInt>(jstring);
                }
            }
            else if (type == "number")
            {
                if (format == "int32")
                {
                    value = Deserialize<AmznPropertyInt>(jstring);
                }
                else if (format == "int64")
                {
                    value = Deserialize<AmznPropertyLong>(jstring);
                }
                else if (format == "float")
                {
                    value = Deserialize<AmznPropertyFloat>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyDouble>(jstring);
                }
            }
            else if (type == "array")
            {

                value = Deserialize<AmznPropertyArray>(jstring);
            }
            else if (type == "boolean")
            {
                value = Deserialize<AmznPropertyBoolean>(jstring);
            }
            else if (type is null)
            {
                if (jobject["ref"] is not null)
                {
                    value = Deserialize<AmznPropertyRef>(jstring);
                }
                else if (jobject["x-docgen-enum-table-extension"] is not null)
                {
                    value = Deserialize<AmznPropertyEnum>(jstring);
                }
                else if (jobject["enum"] is not null)
                {
                    value = Deserialize<AmznPropertyEnum>(jstring);
                }
                else
                {
                    value = Deserialize<AmznPropertyUndefined>(jstring);
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
