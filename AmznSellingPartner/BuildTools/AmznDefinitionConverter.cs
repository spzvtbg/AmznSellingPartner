namespace AmznSellingPartner.BuildTools
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;

    internal class AmznDefinitionConverter : AmznConverter<AmznDefinition>
    {
        public override object ReadJson(JsonReader reader, Type _, object value, JsonSerializer _1)
        {
            var jobject = JObject.Load(reader);
            var type = jobject["type"]?.ToString();
            var format = jobject["format"]?.ToString();
            var jstring = jobject.ToString();

            if (type is null)
            {
                value = Deserialize<AmznDefinitionUndefined>(jstring);
            }
            else if (type == "object")
            {
                value = Deserialize<AmznDefinitionObject>(jstring);
            }
            else if (type == "string")
            {
                if (jobject["x-docgen-enum-table-extension"] is not null)
                {
                    value = Deserialize<AmznDefinitionEnum>(jstring);
                }
                else if (jobject["enum"] is not null)
                {
                    value = Deserialize<AmznDefinitionEnum>(jstring);
                }
                else if (format == "date-time")
                {
                    value = Deserialize<AmznDefinitionDateTime>(jstring);
                }
                else if (format == "date")
                {
                    value = Deserialize<AmznDefinitionDateTime>(jstring);
                }
                else if (format == "ip")
                {
                    value = Deserialize<AmznDefinitionIP>(jstring);
                }
                else if (format == "byte")
                {
                    value = Deserialize<AmznDefinitionBase64>(jstring);
                }
                else
                {
                    value = Deserialize<AmznDefinitionString>(jstring);
                }
            }
            else if (type == "array")
            {
                value = Deserialize<AmznDefinitionArray>(jstring);
            }
            else if (type == "number")
            {
                if (format == "int32")
                {
                    value = Deserialize<AmznDefinitionInt>(jstring);
                }
                else if (format == "int64")
                {
                    value = Deserialize<AmznDefinitionLong>(jstring);
                }
                else if (format == "float")
                {
                    value = Deserialize<AmznDefinitionFloat>(jstring);
                }
                else
                {
                    value = Deserialize<AmznDefinitionDouble>(jstring);
                }
            }
            else if (type == "integer")
            {
                if (format == "int64")
                {
                    value = Deserialize<AmznDefinitionLong>(jstring);
                }
                else
                {
                    value = Deserialize<AmznDefinitionInt>(jstring);
                }
            }
            else if (type == "boolean")
            {
                value = Deserialize<AmznDefinitionBoolean>(jstring);
            }
            else
            {
                this.NotifyUnhandledData(jobject);
            }

            return value;
        }
    }
}
