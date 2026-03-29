#nullable enable

namespace Zep;

public sealed partial class ZepClient
{
    /// <summary>
    /// After Bearer auth is set, convert to Api-Key authorization on the HttpClient.
    /// Zep uses "Authorization: Api-Key {key}" instead of "Authorization: Bearer {key}".
    /// </summary>
    partial void Authorized(System.Net.Http.HttpClient client)
    {
        var apiKey = Authorizations.FirstOrDefault()?.Value;
        if (apiKey is { Length: > 0 })
        {
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Api-Key", apiKey);
        }
    }
}
