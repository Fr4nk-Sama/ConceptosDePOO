using ConceptosPOO;

Console.WriteLine("Hello, Robal!");

Date date1 = new Date(2023, 03, 21);

try
{
    Console.WriteLine(date1.ToString());
    Console.WriteLine(new Date(2023, 11, 45));
    Console.WriteLine(new Date(2023, 19, 21));
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}


Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Daniel",
    LastName = "Saucedo",
    BirthDate = new Date(2001, 11, 15),
    HiringDate = new Date(2023, 03, 21),
    IsActive = true,
    Salary = 1815453.45M
};
//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2020,
    FirstName = "Fidel",
    LastName = "Mitsui",
    BirthDate = new Date(2001, 11, 13),
    HiringDate = new Date(2023, 03, 21),
    IsActive = true,
    Sales = 320000000M,
    CommissionPercentaje = 0.03F
};
//Console.WriteLine(employee2);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2
};

decimal payroll = 0;
foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
Console.WriteLine("                               ==================");
Console.WriteLine($"TOTAL                          {$"{payroll:C2}",18}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 14",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};
Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 32000M,
    Quantity = 17.5F
};
Console.WriteLine(invoice1);
Console.WriteLine(invoice2);