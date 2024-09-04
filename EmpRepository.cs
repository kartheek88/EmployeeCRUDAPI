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


       

    }
}
