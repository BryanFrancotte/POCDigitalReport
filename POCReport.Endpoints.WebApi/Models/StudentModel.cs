using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Models
{
	 public class StudentModel
	 {
		  public Guid Id { get; set; }
		  public string FirstName { get; set; }
		  public string LastName { get; set; }

		  public static List<StudentModel> GenerateStudents() =>
				new List<StudentModel>
				{
					 new StudentModel { Id=Guid.Parse("ee4a8262-972a-47e7-a5dc-997a13a194aa"), FirstName="Test 1", LastName="Eleve" },
					 new StudentModel { Id=Guid.Parse("84ee4481-6a1b-4567-9e5b-73cf580ef702"), FirstName="Test 2", LastName="Eleve" },
					 new StudentModel { Id=Guid.Parse("cdea3aa4-a155-47fa-b818-a1f7a88cd626"), FirstName="Test 3", LastName="Eleve" },
					 new StudentModel { Id=Guid.Parse("d3526426-43f9-4386-9f85-a3cf95fb7457"), FirstName="Test 4", LastName="Eleve" },
					 new StudentModel { Id=Guid.Parse("640d1f09-83da-4844-8d79-7bf7603fe3e9"), FirstName="Test 5", LastName="Eleve" },
				};
	 }
}