using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCReport.Endpoints.WebApi.Models
{
	 public class GradeModel
	 {
		  public Guid Id { get; set; }
		  public Guid StudentId { get; set; }
		  public string LessonName { get; set; }
		  public string LessonNbHours { get; set; }
		  public string Grade { get; set; }

		  public static List<GradeModel> GenerateGrades()
				=> new List<GradeModel>
				{
					 // student 1
					 new GradeModel { Id=Guid.Parse("4504ca7e-13ec-4d81-8410-fd97e89e64cb"), StudentId=Guid.Parse("ee4a8262-972a-47e7-a5dc-997a13a194aa"), LessonName="Sciences", LessonNbHours="3h", Grade="-" },
					 new GradeModel { Id=Guid.Parse("a39efc8e-c59f-4dd1-9c0c-5731b5e684e1"), StudentId=Guid.Parse("ee4a8262-972a-47e7-a5dc-997a13a194aa"), LessonName="Sciences", LessonNbHours="6h", Grade="72.00 %" },
					 new GradeModel { Id=Guid.Parse("f90b5ea3-fbf0-47e2-a5f5-dc89fcab03e0"), StudentId=Guid.Parse("ee4a8262-972a-47e7-a5dc-997a13a194aa"), LessonName="Mathématiques", LessonNbHours="4h", Grade="76.00 %" },
					 new GradeModel { Id=Guid.Parse("0aa9f4f6-759a-4f23-8739-078cf89a6c81"), StudentId=Guid.Parse("ee4a8262-972a-47e7-a5dc-997a13a194aa"), LessonName="Français", LessonNbHours="5h", Grade="42.00 %" },
					 new GradeModel { Id=Guid.Parse("de7047c7-74f6-45ef-a4cc-acd0fb7a6be0"), StudentId=Guid.Parse("ee4a8262-972a-47e7-a5dc-997a13a194aa"), LessonName="Religion", LessonNbHours="2h", Grade="72.00 %" },
					 new GradeModel { Id=Guid.Parse("606dd5a1-38e2-4f5d-bc96-4573bf0baba1"), StudentId=Guid.Parse("ee4a8262-972a-47e7-a5dc-997a13a194aa"), LessonName="Total", LessonNbHours="", Grade="82.00 %" },
					 // student 2
					 new GradeModel { Id=Guid.Parse("16e73fb4-903f-410e-8a76-111e72a022fd"), StudentId=Guid.Parse("84ee4481-6a1b-4567-9e5b-73cf580ef702"), LessonName="Sciences", LessonNbHours="3h", Grade="-" },
					 new GradeModel { Id=Guid.Parse("0f0403c1-667c-4ddb-8e4c-5b95374d5c54"), StudentId=Guid.Parse("84ee4481-6a1b-4567-9e5b-73cf580ef702"), LessonName="Sciences", LessonNbHours="6h", Grade="48.60 %" },
					 new GradeModel { Id=Guid.Parse("0831aa9f-f143-49c1-928b-f567365e5a48"), StudentId=Guid.Parse("84ee4481-6a1b-4567-9e5b-73cf580ef702"), LessonName="Mathématiques", LessonNbHours="4h", Grade="83.60 %" },
					 new GradeModel { Id=Guid.Parse("48f1c2aa-e290-46b8-aef2-1678e24477e0"), StudentId=Guid.Parse("84ee4481-6a1b-4567-9e5b-73cf580ef702"), LessonName="Français", LessonNbHours="5h", Grade="38.60 %" },
					 new GradeModel { Id=Guid.Parse("51dd9ca7-4b09-4abf-b7aa-f708fabad618"), StudentId=Guid.Parse("84ee4481-6a1b-4567-9e5b-73cf580ef702"), LessonName="Religion", LessonNbHours="2h", Grade="87.60 %" },
					 new GradeModel { Id=Guid.Parse("796a9f75-6380-415d-8801-b24447dbf14d"), StudentId=Guid.Parse("84ee4481-6a1b-4567-9e5b-73cf580ef702"), LessonName="Total", LessonNbHours="", Grade="38.60 %" },
					 // student 3
					 new GradeModel { Id=Guid.Parse("b6e7716b-77a8-4127-8aa8-379f41d87c69"), StudentId=Guid.Parse("cdea3aa4-a155-47fa-b818-a1f7a88cd626"), LessonName="Sciences", LessonNbHours="3h", Grade="-" },
					 new GradeModel { Id=Guid.Parse("a9bcae33-2dad-4b02-9e2a-00257faca311"), StudentId=Guid.Parse("cdea3aa4-a155-47fa-b818-a1f7a88cd626"), LessonName="Sciences", LessonNbHours="6h", Grade="52.80 %" },
					 new GradeModel { Id=Guid.Parse("3cb2b234-fb10-49bb-b73a-47bb910d3e56"), StudentId=Guid.Parse("cdea3aa4-a155-47fa-b818-a1f7a88cd626"), LessonName="Mathématiques", LessonNbHours="4h", Grade="73.80 %" },
					 new GradeModel { Id=Guid.Parse("e4f50f2c-394f-4f8e-86fa-8018772e45be"), StudentId=Guid.Parse("cdea3aa4-a155-47fa-b818-a1f7a88cd626"), LessonName="Français", LessonNbHours="5h", Grade="42.80 %" },
					 new GradeModel { Id=Guid.Parse("fb01ffc8-85bc-4f76-9dca-df9131720a0e"), StudentId=Guid.Parse("cdea3aa4-a155-47fa-b818-a1f7a88cd626"), LessonName="Religion", LessonNbHours="2h", Grade="75.80 %" },
					 new GradeModel { Id=Guid.Parse("83ece293-334b-4c61-b1fc-dc1a9592a951"), StudentId=Guid.Parse("cdea3aa4-a155-47fa-b818-a1f7a88cd626"), LessonName="Total", LessonNbHours="", Grade="42.80 %" },
					 // student 4
					 new GradeModel { Id=Guid.Parse("53fb9f67-37db-4c79-887c-24a078559414"), StudentId=Guid.Parse("d3526426-43f9-4386-9f85-a3cf95fb7457"), LessonName="Sciences", LessonNbHours="3h", Grade="53.80 %" },
					 new GradeModel { Id=Guid.Parse("47554da2-60fa-497e-a91b-0e27129b1c5e"), StudentId=Guid.Parse("d3526426-43f9-4386-9f85-a3cf95fb7457"), LessonName="Sciences", LessonNbHours="6h", Grade="-" },
					 new GradeModel { Id=Guid.Parse("88dd3f86-9d4c-4738-b4f6-d11fab61895b"), StudentId=Guid.Parse("d3526426-43f9-4386-9f85-a3cf95fb7457"), LessonName="Mathématiques", LessonNbHours="4h", Grade="54.80 %" },
					 new GradeModel { Id=Guid.Parse("8ae968b3-f8e5-4066-8826-6a9363dd8f4c"), StudentId=Guid.Parse("d3526426-43f9-4386-9f85-a3cf95fb7457"), LessonName="Français", LessonNbHours="5h", Grade="93.80 %" },
					 new GradeModel { Id=Guid.Parse("b6dcb859-c8c2-44b1-ac80-586d8b3cb7d5"), StudentId=Guid.Parse("d3526426-43f9-4386-9f85-a3cf95fb7457"), LessonName="Religion", LessonNbHours="2h", Grade="54.80 %" },
					 new GradeModel { Id=Guid.Parse("61439b5a-8cc1-4d00-80f7-39ae638fe1bf"), StudentId=Guid.Parse("d3526426-43f9-4386-9f85-a3cf95fb7457"), LessonName="Total", LessonNbHours="", Grade="56.80 %" },
					 // student 3h
					 new GradeModel { Id=Guid.Parse("d07e32d0-da45-4972-b4e4-a28afd938f07"), StudentId=Guid.Parse("640d1f09-83da-4844-8d79-7bf7603fe3e9"), LessonName="Sciences", LessonNbHours="3h", Grade="54.00 %" },
					 new GradeModel { Id=Guid.Parse("689c362a-2b43-4afa-9890-2d30bb1d6b2c"), StudentId=Guid.Parse("640d1f09-83da-4844-8d79-7bf7603fe3e9"), LessonName="Sciences", LessonNbHours="6h", Grade="-" },
					 new GradeModel { Id=Guid.Parse("3ea9f438-eec9-40da-beab-bda7b268f54c"), StudentId=Guid.Parse("640d1f09-83da-4844-8d79-7bf7603fe3e9"), LessonName="Mathématiques", LessonNbHours="4h", Grade="45.00 %" },
					 new GradeModel { Id=Guid.Parse("53871609-e330-4275-811f-3505f9a772ac"), StudentId=Guid.Parse("640d1f09-83da-4844-8d79-7bf7603fe3e9"), LessonName="Français", LessonNbHours="5h", Grade="64.00 %" },
					 new GradeModel { Id=Guid.Parse("b51d1acb-f700-4dc5-b9a3-25600e8ace23"), StudentId=Guid.Parse("640d1f09-83da-4844-8d79-7bf7603fe3e9"), LessonName="Religion", LessonNbHours="2h", Grade="44.00 %" },
					 new GradeModel { Id=Guid.Parse("310709a7-e88a-40f2-9a9c-de151f030105"), StudentId=Guid.Parse("640d1f09-83da-4844-8d79-7bf7603fe3e9"), LessonName="Total", LessonNbHours="", Grade="45.00 %" },
				};
	 }
}