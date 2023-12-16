using AutoMapper;
using EfCoreRelation.Data;
using EfCoreRelation.DTOs.Employee;
using EfCoreRelation.Entity.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EfCoreRelation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDBContext appDBContext;


        private readonly IMapper mapper;

        public EmployeeController(AppDBContext appDBContext, IMapper mapper)
        {
            this.appDBContext = appDBContext;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {

            var allData = appDBContext.employees
                //retrive all  address
       .Include(e => e.employeeAddresses)
         .ThenInclude(ex => ex.presentAddresses)
          .Include(e => e.employeeAddresses)
         .ThenInclude(ex => ex.parmanentAddresses)
        //retrive all Accademic Qualification
        .Include(e => e.accademicQualifications)
         .ThenInclude(ex => ex.acQualifOnes)
         .Include(e => e.accademicQualifications)
         .ThenInclude(ex => ex.acQualifTwos)
         .Include(e => e.accademicQualifications)
         .ThenInclude(ex => ex.acQualifThrees)
         //Retrive all Exprience
       .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceOnes)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceTwos)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceThrees)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceFours)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceFives)

       .ToList();

            return Ok(allData);


        }


        //get Employee Data by ID
        [HttpGet]
        [Route("{id:int}")]
        public  IActionResult FindEmployeeByID(int id)
        {
            var employee = appDBContext.employees
                    .Include(e => e.employeeAddresses)
         .ThenInclude(ex => ex.presentAddresses)
          .Include(e => e.employeeAddresses)
         .ThenInclude(ex => ex.parmanentAddresses)
        //retrive all Accademic Qualification
        .Include(e => e.accademicQualifications)
         .ThenInclude(ex => ex.acQualifOnes)
         .Include(e => e.accademicQualifications)
         .ThenInclude(ex => ex.acQualifTwos)
         .Include(e => e.accademicQualifications)
         .ThenInclude(ex => ex.acQualifThrees)
       //Retrive all Exprience
       .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceOnes)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceTwos)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceThrees)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceFours)
           .Include(e => e.workExperiences)
           .ThenInclude(ex => ex.experienceFives)

                    .FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {
                return Ok(employee);
                // Handle case where employee with given ID is not found
              
            }
            return NotFound();


        }




        [HttpPost]
        public async Task<IActionResult> PostAllCustomer(EmployeesDto tempCustommer)

        {
            var newEmployee = mapper.Map<Employee>(tempCustommer);
            appDBContext.employees.Add(newEmployee);
            await appDBContext.SaveChangesAsync();
            /*  return Created($"/customer/${newCustomer.Id}", newCustomer);*/
            return Ok(newEmployee);
        }

















    }
}
