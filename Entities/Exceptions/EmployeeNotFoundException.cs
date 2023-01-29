namespace Entities.Exceptions;

public class EmployeeNotFoundException : NotFoundException
{
    public EmployeeNotFoundException(Guid id) 
        : base($"Employee with the {id} does not exist in the database.")
    {
    }
}
