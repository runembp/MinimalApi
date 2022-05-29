namespace MinimalApi.EndPointDefinitions.Customers.Methods;

public class GetAll
{
    public IResult Handle(ICustomerRepository repository)
    {
        return Results.Ok(repository.GetAll());
    }
}