namespace AmznSellingPartner.BuildTools
{
    using System.Linq;
    using System.Text;

    internal class CsEnum(string name) : CsType(name)
    {
        internal override string ToString(string ns, CsContext csContext)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"namespace {ns}");
            stringBuilder.AppendLine($"{{");

            this.usings.Add("Newtonsoft.Json");
            this.usings.Add("Newtonsoft.Json.Converters");
            this.usings.Add("System.Runtime.Serialization");

            var usingsList = this.usings
                .Union(this.properties.Values
                .SelectMany(x => x.GetUsings()))
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToHashSet()
                .OrderBy(x => x)
                .GroupBy(x => x[0])
                .ToDictionary(x => x.Key, x => x.ToList());

            foreach (var (_, usings) in usingsList)
            {
                foreach (var @using in usings)
                {
                    stringBuilder.AppendLine($"\tusing {@using};");
                }

                stringBuilder.AppendLine();
            }

            if (!string.IsNullOrWhiteSpace(this.description))
            {
                stringBuilder.AppendLine($"\t/// <summary>");

                foreach (var line in this.description.SplitToLines())
                {
                    stringBuilder.AppendLine($"\t/// {line}");
                }

                stringBuilder.AppendLine($"\t/// </summary>");
            }

            foreach (var (attr, val) in this.attributes)
            {
                if (string.IsNullOrWhiteSpace(val))
                {
                    stringBuilder.AppendLine($"\t[{attr}]");
                }
                else
                {
                    stringBuilder.AppendLine($"\t[{attr}({val.Replace("\\", "\\\\")})]");
                }
            }

            stringBuilder.AppendLine($"\t[JsonConverter(typeof(StringEnumConverter))]");

            stringBuilder.AppendLine($"\tpublic enum {this.name}");
            stringBuilder.AppendLine($"\t{{");

            var count = this.members.Count;

            foreach (var (member, summary) in this.members)
            {
                if (!string.IsNullOrWhiteSpace(summary))
                {
                    stringBuilder.AppendLine($"\t\t/// <summary>");

                    foreach (var line in summary.SplitToLines())
                    {
                        stringBuilder.AppendLine($"\t\t/// {line}");
                    }

                    stringBuilder.AppendLine($"\t\t/// </summary>");
                }

                stringBuilder.AppendLine($"\t\t[EnumMember(Value = \"{member}\")]");
                stringBuilder.AppendLine($"\t\t{member.ToEnumMember()},");

                if (--count > 0)
                {
                    stringBuilder.AppendLine();
                }
            }

            stringBuilder.AppendLine($"\t}}");
            stringBuilder.AppendLine($"}}");

            return stringBuilder.ToString();
        }
    }
}