namespace MinimalApi.Interfaces;

public interface ICustomerRepository
{
    Customer? Create(Customer? customer);
    Customer? GetById(Guid id);
    List<Customer> GetAll();
    Customer? Update(Guid id, Customer customer);
    bool Delete(Guid id); 
}