using Before_LSP;
/// <summary>
/// LSP says here that I should use Manager instead of employee without breaking something. 
/// So, I should be able to initialize Employee as a Manager or CEO instead initializing employee as new Employee.
/// What I can not do is I can't throw an exception where the employee would not have. Issue in this case is that CEO has another method and it will
/// throw an error because CEO has no manager. This is a violation of LSP.
/// Inheritance structure is not good.
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

        employee.FirstName = "Ahmed";
        employee.LastName = "A";
        employee.AssignManager(manager);
        employee.CalculatePerHourRate(2);
        
        Console.WriteLine($"Employee {employee.FirstName} salary is {employee.Salary}/hour.");
        Console.ReadLine();
    }
}