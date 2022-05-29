namespace MinimalApi.EndPointDefinitions.Customers.Methods;

public class Create
{
    public IResult Handle(ICustomerRepository repository, Customer customer)
    {
        var createdCustomer = repository.Create(customer);
        return Results.Created($"/customers/{customer.Id}", createdCustomer);
    }
}