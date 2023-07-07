using Microsoft.AspNetCore.Mvc.Testing;

namespace Tests
{
    public class Sanity
    {
        [Fact]
        public async Task CallTheEndpoint()
        {
            var app = new WebApplicationFactory<Program>();
            var client = app.CreateClient();

            var response = await client.GetAsync("WeatherForecast");
            response.EnsureSuccessStatusCode();
        }
    }
}