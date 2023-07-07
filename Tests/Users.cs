namespace Tests;

public class Users
{
    /// <summary>
    /// {
    ///   "user": {
    ///     "username": "Jacob",
    ///     "email": "jake@jake.jake",
    ///     "password": "jakejake"
    ///    }
    ///  }
    /// </summary>
    /// <returns></returns>
    [Fact]
    public async Task Register()
    {
        var client = Factory.CreateHttpClient();

        var response = await client.PostAsync("/api/users", new StringContent(@"{
  ""user"":{
    ""username"": ""Jacob"",
    ""email"": ""jake@jake.jake"",
    ""password"": ""jakejake""
  }
}"));
        response.EnsureSuccessStatusCode();
    }
}