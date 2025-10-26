namespace BugStore.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this WebApplication app)
    {
        app.MapGet("/v1/customers", () => "Hello World!");
        app.MapGet("/v1/customers/{id}", () => "Hello World!");
        app.MapPost("/v1/customers", () => "Hello World!");
        app.MapPut("/v1/customers/{id}", () => "Hello World!");
        app.MapDelete("/v1/customers/{id}", () => "Hello World!");
    }
}