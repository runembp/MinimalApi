namespace MinimalApi.Repositories;

public class CustomerRepository : ICustomerRepository
{
    private readonly Dictionary<Guid, Customer> _customers = new();
    
    public Customer? Create(Customer? customer)
    {
        if (customer is null)
        {
            return customer;
        }
        
        customer.Id = Guid.NewGuid();
        _customers[customer.Id] = customer;

        return customer;
    }

    public Customer? GetById(Guid id)
    {
        _customers.TryGetValue(id, out var customer);
        return customer;
    }

    public List<Customer> GetAll()
    {
        return _customers.Values.ToList();
    }

    public Customer? Update(Guid id, Customer updatedCustomer)
    {
        var customer = _customers[id];
        customer.FullName = updatedCustomer.FullName;
        return customer;
    }

    public bool Delete(Guid id)
    {
        return _customers.Remove(id);
    }
}
