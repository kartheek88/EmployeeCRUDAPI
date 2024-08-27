using EmployeeAPI.Context;
using EmployeeAPI.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAPI
{
    public class EmpRepository : IEmpRepo
    {
        private readonly EmpContext _empcontext;
        public EmpRepository(EmpContext empconext)
        {
            _empcontext = empconext;
        }


        public async Task AddEmployeeAsync(EmpModel empModel)
        {
            _empcontext.Add(empModel);
             await _empcontext.SaveChangesAsync();
        }


        public async Task<IEnumerable<EmpModel>> GelAllEmpAsync()
        {
            return await _empcontext.EmployeeList.ToListAsync();
        }

        public async Task <EmpModel> GetEmpByIdAsync( int id)
        {
            return await _empcontext.EmployeeList.FindAsync(id);
        }

        public async Task DeleteEmpAsync(EmpModel empModel,int id)
        {
            var Emp = await _empcontext.EmployeeList.FindAsync(id);
            if (Emp != null)
            {
                _empcontext.EmployeeList.Remove(Emp);
                await _empcontext.SaveChangesAsync();
            }
        }

        public async Task UpdateEmpAsync(EmpModel empModel)
        {
            _empcontext.Entry(empModel).State = EntityState.Modified;
            await _empcontext.SaveChangesAsync();
        }

    }
}
