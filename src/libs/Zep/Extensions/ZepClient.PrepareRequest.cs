#nullable enable

namespace Zep;

public sealed partial class ZepClient
{
    // Zep uses "Authorization: Api-Key {key}" instead of "Authorization: Bearer {key}".
    // Rewrite the scheme in the shared Authorizations list so all sub-clients
    // (SubpackageThread, SubpackageUser, etc.) send the correct header.
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        for (var i = 0; i < Authorizations.Count; i++)
        {
            var auth = Authorizations[i];
            if (auth is { Type: "Http", Name: "Bearer" })
            {
                Authorizations[i] = new EndPointAuthorization
                {
                    Type = auth.Type,
                    Location = auth.Location,
                    Name = "Api-Key",
                    Value = auth.Value,
                };
            }
        }
    }
}
