using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Models
{
	 public class CSVImportModel
	 {
		  public string StudentFirstName { get; set; }
		  public string StudentLastName { get; set; }
		  public Dictionary<string, string> GradeList { get; set; }
	 }
}