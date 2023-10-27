
using Interfaces;

PersonManager personManager = new PersonManager();
personManager.Add(new Customer { Id = 1, FirstName = "Barış", LastName = "Yıldırım", Address = "Aydın" });

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new OracleCustomerDal());

ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new SqlServerCustomerDal(),
    new OracleCustomerDal()
};

foreach(var customerDal in customerDals)
{
    customerDal.Add();
}

interface IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address {  get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }
}

class PersonManager
{
    public void Add(Customer customer)
    {
        Console.WriteLine(customer.FirstName);
    }
}