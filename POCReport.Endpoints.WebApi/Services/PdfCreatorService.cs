using DinkToPdf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Services
{
	 public class PdfCreatorService : IPdfCreatorService
	 {
		  private readonly IConverter _converter;

		  public PdfCreatorService(IConverter converter)
		  {
				_converter = converter;
		  }

		  private static string CreateHTMLFile()
		  {
				StringBuilder builder = new StringBuilder();
				builder.Append(@"
									 <html>
										  <head>

										  </head>
										  <body>
												<div class='header'><h1>This is the generated PDF Report!</h1></div>
												<table align='center'>
													 <tr>
														  <th>Cours </th>
														  <th></th>
													 </tr>
										  </body>
									 ");
				return null;
		  }

		  public byte[] GeneratePdfDocument()
		  {
				return null;
		  }
	 }
}