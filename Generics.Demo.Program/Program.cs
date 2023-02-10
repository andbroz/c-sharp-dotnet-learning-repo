using Generics.Demo.Program.Repositories;
using Generics.Demo.Program.Entities;
using Generics.Demo.Program.Data;

var empployeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
AddEmployees(empployeeRepository);
AddManagers(empployeeRepository);



empployeeRepository.Save();
GetEmployeeById(empployeeRepository);
WriteAllToConsole(empployeeRepository);



var organizationRepository = new ListRepository<Organization>();
AddOrganizations(organizationRepository);
WriteAllToConsole(organizationRepository);
organizationRepository.Save();

static void GetEmployeeById(IRepository<Employee> repository)
{
    var employee = repository.GetById(2);
    Console.WriteLine($"The employee with id 2 is: {employee}");
}

static void AddOrganizations(IWriteRepository<Organization> repository)
{
    repository.Add(new Organization { Name = "Pajacyk" });
    repository.Add(new Organization { Name = "Bankster" });
    repository.Add(new Organization { Name = "Makrohard" });
    repository.Add(new Organization { Name = "Goooogle" });
}

static void AddEmployees(IWriteRepository<Employee> repository)
{
    var kacper = new Employee { FirstName = "Kacper" };
    repository.Add(kacper);
    repository.Add(new Employee { FirstName = "Anna" });
    repository.Add(new Employee { FirstName = "Zofia" });
    repository.Add(new Employee { FirstName = "Kazimierz" });
}

void AddManagers(IWriteRepository<Manager> repository)
{
    repository.Add(new Manager { FirstName = "Milosz" });
    repository.Add(new Manager { FirstName = "Piotrek" });
    repository.Save();
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();

    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}