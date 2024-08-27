using EmployeeAPI.Context;
using EmployeeAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace EmployeeAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        private readonly IEmpRepo _emprepo;

        public EmpController(IEmpRepo emprepo)
        {
            _emprepo = emprepo;
        }

        [HttpPost]
        public async Task<IActionResult> AddEmp(EmpModel empModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                   await _emprepo.AddEmployeeAsync(empModel);
                    return CreatedAtAction(nameof(AddEmp), empModel);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return BadRequest();

        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetEmpById(int id)
        //{
        //    if (id == 0)
        //    {
        //        return BadRequest();
        //    }
        //    var emp = await _empContext.EmployeeList.FindAsync(id);

        //    if (emp == null)
        //    {
        //        return NotFound($"Employee with {id} not found");
        //    }
        //    return Ok(emp);
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<EmpModel>>> GetAllEmp()
        //{
        //    var employees = await _empContext.EmployeeList.ToListAsync();
        //    return Ok(employees);
        //}
        //[HttpPut("{Id}")]
        //public async Task<IActionResult> UpdateEmp(int Id, EmpModel empModel)
        //{
        //    // Validate incoming model and the Id parameter
        //    if (empModel == null)
        //    {
        //        return BadRequest("No Data provided.");
        //    }

        //    // Optional: Check if the route Id matches the model Id (if applicable)
            

        //    // Find the employee by Id
        //    var existingEmp = await _empContext.EmployeeList.FindAsync(Id);
        //    if (existingEmp == null)
        //    {
        //        return NotFound($"Employee with Id {Id} not found.");
        //    }
        //    if (existingEmp.Id != Id)
        //    {
        //        return BadRequest("Employee ID in the model does not match the ID in the route.");
        //    }

        //    // Update the employee details
        //    existingEmp.First_Name = empModel.First_Name;
        //    existingEmp.Last_Name = empModel.Last_Name;
        //    existingEmp.Gender = empModel.Gender;
        //    existingEmp.Age = empModel.Age;
        //    existingEmp.Designation = empModel.Designation;
        //    existingEmp.Experience = empModel.Experience;

        //    // Save changes to the database
        //    await _empContext.SaveChangesAsync();

        //    return Ok(existingEmp);
        //}

        //[HttpDelete("{Id}")]

        //public async Task <IActionResult> DeleteEmp(EmpModel empModel , int Id)
        //{
        //    if (Id ==0 || Id ==null)
        //    {
        //        return BadRequest("Please Enter Valid ID");
        //    }
        //    try
        //    {
        //        var ExistingEmp = await _empContext.EmployeeList.FindAsync(Id);
        //        if(ExistingEmp ==null)
        //        {
        //            return NotFound("Data Not found with {Id}");
        //        }
        //         _empContext.EmployeeList.Remove(ExistingEmp);
        //        await _empContext.SaveChangesAsync();
        //    }
        //    catch(Exception)
        //    {
        //        throw;
        //    }
        //    return CreatedAtAction(nameof(UpdateEmp),$"{Id} Deleted");

        //}



    }
}
