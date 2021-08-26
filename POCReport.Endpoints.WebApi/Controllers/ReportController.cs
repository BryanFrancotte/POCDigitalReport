using Microsoft.AspNetCore.Mvc;
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
		  public IActionResult CSVUpload()
		  {
				throw new NotImplementedException();
		  }

		  public IActionResult ZipDownload()
		  {
				throw new NotImplementedException();
		  }

		  public IActionResult PdfDownload(int studentId)
		  {
				throw new NotImplementedException();
		  }

		  private void ConvertCsvToObject()
		  {
				// TODO
		  }

		  private void CreatePdfFile()
		  {
				// TODO
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
	 }
}