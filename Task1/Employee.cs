public class Employee
{
    public int Id { get;}
    public string? FirstName {get;}
    public string? LastName {get;}
    public int Salary {get; set;}
    public Employee(int id, string firstName, string lastName, int salary)
    {
        this.FirstName = firstName;
        this.Id = id;
        this.LastName = lastName;
        this.Salary = salary;
    }
    public int GetAnnualSalary()
    {
        return Salary * 12;
    }
    public string Name()
    {
        return $"{FirstName}, {LastName}";
    }
    public int RaiseSalary(int percent)
    {
        int n = percent * Salary;
        return n / 100;
    }
    public override string ToString()
    {
        return $"Id={Id}, name={FirstName}, lastname={LastName}, salary={Salary}";
    }
}
