using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Services
{
	 internal interface IPdfCreatorService
	 {
		  public byte[] GeneratePdfDocument();
	 }
}