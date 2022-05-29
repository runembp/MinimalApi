using MinimalApi.EndPointDefinitions.Customers.Methods;

namespace MinimalApi.EndPointDefinitions.Customers;

public class CustomerEndpointDefinitions : IEndpointDefinition
{
    private readonly GetById _getById = new ();
    private readonly GetAll _getAll = new ();
    private readonly Create _create = new();
    private readonly Update _update = new();
    private readonly Delete _delete = new();

    public void DefineEndpoints(WebApplication app)
    {
        app.MapGet("/customers", _getAll.Handle);
        app.MapGet("/customers/{id:guid}", _getById.Handle);
        app.MapPost("/customers", _create.Handle);
        app.MapPut("/customers/{id:guid}", _update.Handle);
        app.MapDelete("/customers/{id:guid}", _delete.Handle);
    }

    public void DefineServices(IServiceCollection services)
    {
        services.AddSingleton<ICustomerRepository, CustomerRepository>();
    }
}