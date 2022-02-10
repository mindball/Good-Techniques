using System.ComponentModel.DataAnnotations;

namespace SwaggerConfig.Models.Employee
{
    public class EmployeeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]    
        public string EmailId { get; set; }
    }
}
