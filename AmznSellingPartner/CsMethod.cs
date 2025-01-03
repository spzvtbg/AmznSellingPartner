namespace AmznSellingPartner
{
    using System.Collections.Generic;

    internal class CsMethod(string name)
    {
        private bool deprecated;
        private string description;
        private string name = name;
        private string requestType;
        private string responseType;

        internal CsMethod HasDescription(string description)
        {
            this.description = description;

            return this;
        }

        internal CsMethod HasRequestType(string requestType)
        {
            this.requestType = requestType;

            return this;
        }

        internal CsMethod HasResponseType(string responseType)
        {
            this.responseType = responseType;

            return this;
        }

        internal CsMethod IsDeprecated(bool deprecated)
        {
            this.deprecated = deprecated;

            return this;
        }

        internal bool IsDeprecated() => this.deprecated;

        internal IEnumerable<object> AsEnumerable()
        {
            if (!string.IsNullOrWhiteSpace(this.description))
            {
                yield return $"/// <summary>";

                foreach (var line in this.description.SplitToLines())
                {
                    yield return $"/// {line}";
                }

                yield return $"/// </summary>";
            }

            if (this.deprecated)
            {
                yield return $"[Obsolete]";
            }

            yield return $"public async Task<{this.responseType}> {this.name}({this.requestType} request)";
            yield return $"    => await this.SendAsync<{this.responseType}>(request);";
        }
    }
}