namespace MinimalApi.EndPointDefinitions.Customers.Methods;

public class Delete
{
    public IResult Handle(ICustomerRepository repository, Guid id)
    {
        var result = repository.Delete(id);
        return result ? Results.NoContent() : Results.BadRequest();
    }
}