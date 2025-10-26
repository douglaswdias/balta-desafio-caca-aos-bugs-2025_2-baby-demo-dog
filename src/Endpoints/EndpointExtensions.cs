namespace BugStore.Endpoints;

public static class EndpointExtensions
{
    public static void MapEndpoints(this WebApplication app)
    {
        app.MapCustomerEndpoints();
        app.MapProductEndpoints();
        app.MapOrderEndpoints();
    }
}