namespace MinimalApi.EndPointDefinitions.Customers.Methods;

public class Update
{
    public IResult Handle(ICustomerRepository repository, Guid id, Customer customer)
    {
        var result = repository.Update(id, customer);
        return result is not null ? Results.Ok(result) : Results.BadRequest();
    }
}