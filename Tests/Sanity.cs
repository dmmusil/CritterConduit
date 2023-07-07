namespace Tests;

public class Sanity
{
    [Fact]
    public async Task CallTheEndpoint()
    {
        var client = Factory.CreateHttpClient();

        var response = await client.GetAsync("WeatherForecast");
        response.EnsureSuccessStatusCode();
    }
}