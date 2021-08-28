using DinkToPdf;
using DinkToPdf.Contracts;
using POCReport.Endpoints.WebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

		  private static string CreateHTMLFile(StudentModel student, List<GradeModel> gradeList)
		  {
				StringBuilder builder = new StringBuilder();
				builder.AppendFormat(@"
									 <html>
										  <head></head>
										  <body>
												<div class='body-warper'>
													 <div class='header'>
														  <img src='{0}' />
													 </div>
													 <div class='title'>
														  <h1>BULLETIN DE TOUSSAINT</h1>
														  <h2>{1} {2}</h2>
													 </div>
													 <table align='center'>
														  <tr>
																<th></th>
																<th></th>
																<th>Toussaint</th>
																<th>Noël</th>
																<th>Pâques</th>
																<th>Juin</th>
														  </tr>
									 ", Path.Combine(Directory.GetCurrentDirectory(), "assets", "img", "bulletin_entete.png"), student.LastName, student.FirstName);
				foreach (GradeModel grade in gradeList)
				{
					 if (!Equals(grade.Grade, "-"))
					 {
						  builder.AppendFormat(@"<tr>
														  <td class='lesson-name'>{0}</td>
														  <td class='lesson-hours'>{1}</td>
														  <td>{2}</td>
														  <td></td>
														  <td></td>
														  <td></td>
													</tr>
						  ", grade.LessonName, grade.LessonNbHours, grade.Grade);
					 }
				}
				builder.AppendFormat(@"</table>
											<div class='footer'>
												<img src='{0}' />
										  </div>
									 </div>
								</body>
							</html>
				", Path.Combine(Directory.GetCurrentDirectory(), "assets", "img", "bulletin_piedpage.png"));

				return builder.ToString();
		  }

		  public byte[] GeneratePdfDocument(StudentModel student, List<GradeModel> gradeList)
		  {
				GlobalSettings globalSettings = new GlobalSettings
				{
					 ColorMode = ColorMode.Color,
					 Orientation = Orientation.Portrait,
					 PaperSize = PaperKind.A4,
					 Margins = new MarginSettings { Top = 10 },
					 DocumentTitle = "PDF Report"
				};

				ObjectSettings objectSettings = new ObjectSettings
				{
					 PagesCount = true,
					 HtmlContent = CreateHTMLFile(student, gradeList),
					 WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "assets", "styles.css") },
					 FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
				};

				HtmlToPdfDocument pdf = new HtmlToPdfDocument()
				{
					 GlobalSettings = globalSettings,
					 Objects = { objectSettings }
				};

				var file = _converter.Convert(pdf);

				if (file == null)
				{
					 throw new Exception("Pdf not created !!!");
				}

				return file;
		  }
	 }
}