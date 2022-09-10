using System.ComponentModel.DataAnnotations;

public class Program
{
    private static void Main(string[] args)
    {
        Customer customer = new Customer { Id=1,Name="jdkjd"};
        CustomerDal customerDal= new CustomerDal();
        customerDal.Add(customer);
    }
     
    

}
[ToTable("TblCustomers")]
[ToTable("Customers")]
class Customer
{
    public int Id { get; set; }
    [RequiredProperty]
    public string Name { get; set; }
    
}
[AttributeUsage(AttributeTargets.Property,AllowMultiple =true)]
public class RequiredPropertyAttribute : Attribute
{
}

class CustomerDal
{
    [Obsolete("Don't use Add")]
    public void Add(Customer customer)
    {
        Console.WriteLine("{0} , {1} is added", customer.Id, customer.Name);

    }
}
[AttributeUsage(AttributeTargets.Class,AllowMultiple =true)]
class ToTableAttribute : Attribute
{
    private string _tableName;

    public ToTableAttribute(string tableName)
    {
        _tableName = tableName;
    }
}