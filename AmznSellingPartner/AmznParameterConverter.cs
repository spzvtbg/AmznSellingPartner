namespace AmznSellingPartner
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using System;

    internal class AmznParameterConverter : AmznConverter<AmznParameter>
    {
        public override object ReadJson(JsonReader reader, Type _, object value, JsonSerializer _1)
        {
            var jobject = JObject.Load(reader);
            var jstring = jobject?.ToString();
            var type = jobject["type"]?.ToString();
            var format = jobject["format"]?.ToString();

            if (jobject["ref"] is not null)
            {
                value = Deserialize<AmznParameterRef>(jstring);
            }
            else if (type == "integer")
            {
                if (format == "int64")
                {
                    value = Deserialize<AmznParameterLong>(jstring);
                }
                else
                {
                    value = Deserialize<AmznParameterInt>(jstring);
                }
            }
            else if (type == "number")
            {
                if (format == "int32")
                {
                    value = Deserialize<AmznParameterInt>(jstring);
                }
                else if (format == "int64")
                {
                    value = Deserialize<AmznParameterLong>(jstring);
                }
                else if (format == "float")
                {
                    value = Deserialize<AmznParameterFloat>(jstring);
                }
                else
                {
                    value = Deserialize<AmznParameterDouble>(jstring);
                }
            }
            else if (type == "object")
            {
                this.NotifyUnhandledData(jobject);
            }
            else if (type == "string")
            {
                if (format == "boolean")
                {
                    value = Deserialize<AmznParameterBoolean>(jstring);
                }
                else if (format == "date-time")
                {
                    value = Deserialize<AmznParameterDateTime>(jstring);
                }
                else if (format == "date")
                {
                    value = Deserialize<AmznParameterDateTime>(jstring);
                }
                else if (jobject["enum"] is not null)
                {
                    value = Deserialize<AmznParameterEnum>(jstring);
                }
                else if (jobject["collectionFormat"] is not null)
                {
                    value = Deserialize<AmznParameterCsv>(jstring);
                }
                else
                {
                    value = Deserialize<AmznParameterString>(jstring);
                }
            }
            else if (type == "array")
            {
                if (jobject["items"] is not null)
                {
                    if (jobject["x-docgen-enum-table-extension"] is not null)
                    {
                        value = Deserialize<AmznParameterItemsEnum>(jstring);
                    }
                    else
                    {
                        value = Deserialize<AmznParameterItems>(jstring);
                    }
                }
                else
                {
                    this.NotifyUnhandledData(jobject);
                }
            }
            else if (type == "boolean")
            {
                value = Deserialize<AmznParameterBoolean>(jstring);
            }
            else if (type is null)
            {
                if (jobject["schema"] is not null)
                {
                    value = Deserialize<AmznParameterSchema>(jstring);
                }
                else
                {
                    this.NotifyUnhandledData(jobject);
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
