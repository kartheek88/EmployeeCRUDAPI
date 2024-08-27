using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EmployeeAPI
{
    public class EmpModel
    {
        
        public int Id { get; set; }

        [Required]
        public string First_Name { get; set; }

        [Required]
        public string Last_Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public string Experience { get; set; }

    }
}
