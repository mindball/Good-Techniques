using Microsoft.AspNetCore.Mvc;

using SwaggerConfig.Models.Employee;

namespace SwaggerConfig.Controllers.Employee
{
    public class EmployeeController : ControllerBase
    {
        //Get: api/Employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<EmployeeViewModel>> Get()
        {
            var employees = this.GetEmployees();

            if(employees.Count == 0 || employees == null )
            {
                return NotFound();
            }

            return GetEmployees();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<EmployeeViewModel> Get(int id)
        {
            var employee = GetEmployees().Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }


        // POST: api/Employee
        [HttpPost]
        [Produces("application/json")]
        public EmployeeViewModel Post([FromBody] EmployeeViewModel employee)
        {
            // Logic to create new Employee
            return new EmployeeViewModel();
        }
        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] EmployeeViewModel employee)
        {
            // Logic to update an Employee
        }

        // DELETE: api/Employee/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private List<EmployeeViewModel> GetEmployees()
        {
            return new List<EmployeeViewModel>()
        {
            new EmployeeViewModel()
            {
                Id = 1,
                FirstName= "John",
                LastName = "Smith",
                EmailId ="John.Smith@gmail.com"
            },
            new EmployeeViewModel()
            {
                Id = 2,
                FirstName= "Jane",
                LastName = "Doe",
                EmailId ="Jane.Doe@gmail.com"
            }
        };
        }
    }
}
