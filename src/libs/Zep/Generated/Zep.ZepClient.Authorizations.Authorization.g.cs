
#nullable enable

namespace Zep
{
    public sealed partial class ZepClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingAuthorization(
 )
        {

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Zep.EndPointAuthorization
            {
                Type = "",
                SchemeId = "ApiKey",
                Location = "",
                Name = "",
                Value = "",
            });
        }
    }
}