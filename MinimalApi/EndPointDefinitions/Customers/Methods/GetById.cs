namespace MinimalApi.EndPointDefinitions.Customers.Methods;

public class GetById
{
    public IResult Handle(ICustomerRepository repository, Guid id)
    {
        var customer = repository.GetById(id);
        return customer is not null ? Results.Ok(customer) : Results.NotFound();
    }
}