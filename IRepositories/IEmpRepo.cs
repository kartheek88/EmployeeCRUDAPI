using EmployeeAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeAPI.Repositories
{
    public interface IEmpRepo
    {
        Task AddEmployeeAsync(EmpModel empModel);
        Task<IEnumerable<EmpModel>> GelAllEmpAsync();
        Task<EmpModel> GetEmpByIdAsync(int id);
        Task DeleteEmpAsync(EmpModel empModel, int id);
        Task UpdateEmpAsync(EmpModel empModel);
    }
}
