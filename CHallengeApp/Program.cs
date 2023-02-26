using CHallengeApp;

Employee employee1 = new Employee("Kasia", "Mała", 35);
Employee employee2 = new Employee("Ania", "Duża", 45);
Employee employee3 = new Employee("Ola", "Nowak", 50);

employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(4);
employee1.AddScore(3);
employee1.AddScore(2);

employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(5);
employee2.AddScore(7);
employee2.AddScore(4);

employee3.AddScore(9);
employee3.AddScore(4);
employee3.AddScore(5);
employee3.AddScore(9);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()

{
   employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var Employee in employees)
{
    if (Employee.Result > maxResult)
    {
        employeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }
}


Console.WriteLine("Pracownikiem z największą ilością punktów jest: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " " + maxResult + " " + "punktów");
