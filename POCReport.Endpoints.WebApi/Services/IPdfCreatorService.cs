using POCReport.Endpoints.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Services
{
	 public interface IPdfCreatorService
	 {
		  public byte[] GeneratePdfDocument(StudentModel student, List<GradeModel> gradeList);
	 }
}