using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts;

public interface IEmployeeRepository
{
    Task<PagedList<Employee>> GetEmployeesAsync(Guid CompanyId, EmployeeParameters employeeParameters, bool trackChanges);
    Task<Employee> GetEmployeeAsync(Guid CompanyId, Guid EmployeeId, bool trackChanges);
    void CreateEmployeeForCompany(Guid companyId, Employee employee);
    void DeleteEmployee(Employee employee);
}
