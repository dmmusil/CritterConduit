using Microsoft.AspNetCore.Mvc.Testing;

namespace Tests;

internal class Factory
{
    public static HttpClient CreateHttpClient() => new WebApplicationFactory<Program>().CreateClient();
}