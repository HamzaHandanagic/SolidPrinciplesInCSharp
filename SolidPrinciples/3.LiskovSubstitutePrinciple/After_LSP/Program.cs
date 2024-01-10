using After_LSP;
/// <summary>
/// Fixed for LSP. 
/// Manager truly implements Employee class. Employee is managed so Employee implements IManaged and also BaseEmployee.
/// CEO implements BaseEmployee and IManager.
/// In this way we have true inheritance structure.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Manager manager = new Manager();

        manager.FirstName = "Hamza";
        manager.LastName = "H";
        manager.CalculatePerHourRate(4);

        Employee employee = new Employee();
        // IT CAN BE ALSO:
        //Employee employee = new Manager();

        employee.FirstName = "Ahmed";
        employee.LastName = "A";
        employee.AssignManager(manager);
        employee.CalculatePerHourRate(2);

        Console.WriteLine($"Employee {employee.FirstName} salary is {employee.Salary} $ per hour.");
        Console.ReadLine();
    }
}
