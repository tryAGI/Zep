namespace Zep.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ZepClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ZEP_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ZEP_API_KEY environment variable is not found.");

        var client = new ZepClient(apiKey);
        
        return client;
    }
}
