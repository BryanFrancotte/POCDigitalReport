using Microsoft.AspNetCore.Mvc;
using POCReport.Endpoints.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Controllers
{
	 [ApiController]
	 [Route("[controller]")]
	 public class StudentController : ControllerBase
	 {
		  [HttpGet]
		  [Route("get/all")]
		  public IActionResult GetStudents()
		  {
				var studentList = StudentModel.GenerateStudents();
				return Ok(studentList);
		  }

		  [HttpGet]
		  [Route("get/{number}")]
		  public IActionResult GetStudentById(int number)
		  {
				var student = StudentModel.GenerateStudents()[number - 1];
				return Ok(student);
		  }
	 }
}