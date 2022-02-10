using Microsoft.AspNetCore.Mvc;
using SwaggerConfig.Models.Employee;

namespace SwaggerConfig.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// Get list of all Employees
        /// </summary>
        /// <returns>The list of EmployeeViewMode</returns>
        //  GET: api/Employees/
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[Produces("application/json")]       
        public ActionResult<IEnumerable<EmployeeViewModel>> Get()
        {
            var employees = this.GetEmployees();

            if (employees.Count == 0 || employees == null)
            {
                return NotFound();
            }

            return GetEmployees();
        }

        /// <summary>
        /// Get employee by id
        /// </summary>
        /// <param name="id">Employee id</param>
        /// <returns>employee model filter by id</returns>
        /// <response code="201">Returns the model by id</response>
        /// <response code="400">If employee doesnt exist</response>
        // GET: api/Employee/{id}
        [HttpGet("{id}", Name = "Get")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //[Produces("application/json")]        
        public ActionResult<EmployeeViewModel> Get(int id)
        {
            var employee = GetEmployees().Find(e => e.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return employee;
        }

        /// <summary>
        /// Create employee
        /// </summary>
        ///<remarks>
        ///Sample request:
        /// 
        ///     Post api/Employee
        ///     {
        ///         "firstName": "Mike",
        ///         "lastName": "Bowle",
        ///         "emailId": "test@gmail.com"
        ///     }
        ///     
        ///</remarks>
        /// <param name="employee"></param>
        /// <returns></returns>
        // POST: api/Employee
        [HttpPost]
        //[Produces("application/json")]  
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
