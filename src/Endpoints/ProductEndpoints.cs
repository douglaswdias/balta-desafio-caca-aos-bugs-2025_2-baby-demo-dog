namespace BugStore.Endpoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints(this WebApplication app)
    {
        app.MapGet("/v1/products", () => "Hello World!");
        app.MapGet("/v1/products/{id}", () => "Hello World!");
        app.MapPost("/v1/products", () => "Hello World!");
        app.MapPut("/v1/products/{id}", () => "Hello World!");
        app.MapDelete("/v1/products/{id}", () => "Hello World!");
    }
}