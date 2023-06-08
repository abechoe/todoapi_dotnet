using Microsoft.AspNetCore.Mvc.Testing;

namespace TodoApi.Tests;

public class UnitTest1
{
    [Fact]
    public async Task TestTodoList()
    {
        await using var application = new WebApplicationFactory<Program>();
        using var client = application.CreateClient();

        var response = await client.GetAsync("api/todo/");
        var content = await response.Content.ReadAsStringAsync();

        Assert.True(response.StatusCode == System.Net.HttpStatusCode.OK);
        Assert.Equal("Hello World!", content);
    }
}