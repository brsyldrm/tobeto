using Classes;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.City = "Ankara";
customer.Id = 1;
customer.FirstName = "Barış";
customer.LastName = "Yıldırım";

Customer customer2 = new Customer
{
    Id = 2,
    City = "İstanbul",
    FirstName = "Derin",
    LastName = "Demiroğ"
};

Console.WriteLine(customer2.FirstName);



