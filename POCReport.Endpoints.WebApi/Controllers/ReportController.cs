using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using POCReport.Endpoints.WebApi.Models;
using POCReport.Endpoints.WebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Controllers
{
	 [ApiController]
	 [Route("[controller]")]
	 public class ReportController : ControllerBase
	 {
		  private IPdfCreatorService _pdfCreator;

		  public ReportController(IConverter converter)
		  {
				_pdfCreator = new PdfCreatorService(converter);
		  }

		  public IActionResult CSVUpload()
		  {
				throw new NotImplementedException();
		  }

		  public IActionResult ZipDownload()
		  {
				throw new NotImplementedException();
		  }

		  [HttpGet]
		  [Route("pdf/get/{number}")]
		  public IActionResult GetPdf(/*Guid studentId*/ int number)
		  {
				var file = CreatePdfFile(number);
				return File(file, "application/pdf");
		  }

		  [HttpGet]
		  [Route("pdf/download/{number}")]
		  public IActionResult PdfDownload(/*Guid studentId*/ int number)
		  {
				var file = CreatePdfFile(number);
				var student = GetStudent(number);
				string fileName = student.LastName + "_" + student.FirstName + ".pdf";
				return File(file, "application/pdf", fileName);
		  }

		  private void ConvertCsvToObject()
		  {
				// TODO
		  }

		  private byte[] CreatePdfFile(/*Guid studentId*/ int number)
		  {
				var student = GetStudent(number);
				var gradeList = GetGrades(student.Id);

				return _pdfCreator.GeneratePdfDocument(student, gradeList);
		  }

		  private void SavePdfFile()
		  {
				// TODO
		  }

		  private void DeletePdfFile()
		  {
				// TODO
		  }

		  private void CreateZipBundle()
		  {
				// TODO
		  }

		  private StudentModel GetStudent(int number)
				=> StudentModel.GenerateStudents()[number - 1];

		  private List<GradeModel> GetGrades(Guid studentId)
				=> GradeModel.GenerateGrades().Where(x => x.StudentId == studentId).ToList();
	 }
}