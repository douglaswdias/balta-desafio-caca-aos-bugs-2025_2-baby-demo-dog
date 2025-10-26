namespace BugStore.Endpoints;

public static class OrderEndpoints
{
    public static void MapOrderEndpoints(this WebApplication app)
    {
        app.MapGet("/v1/orders/{id}", () => "Hello World!");
        app.MapPost("/v1/orders", () => "Hello World!");
    }
}