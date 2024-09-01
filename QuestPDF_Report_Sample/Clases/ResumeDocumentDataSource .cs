using QuestPDF.Helpers;
using QuestPDF_Report_Sample.Clases.Models;

namespace QuestPDF_Report_Sample.Clases
{
    public static class ResumeDocumentDataSource
    {
        private static Random Random = new Random();

        public static ResumeModel GetResumeDetails()
        {

            //Random data generated
            //ResumeModel rm = new ResumeModel
            //{
            //    ContactData = GenerateRandomContactData(),
            //    FullName = "Joaquín Gregoire",
            //    Experience = GenerateExperiences()
            //};


            ResumeModel rm = new ResumeModel
            {
                ContactData = GenerateFixedContactData(),
                FullName = "Joaquín Gregoire",
                Experience = GenerateRealExperiences()
            };



            return rm;
            
        }

        private static ContactData GenerateFixedContactData()
        {
            return new ContactData
            {
                Country = "Argentina",
                Mail = "gregoirejoaquin@gmail.com",
                City = "Santa Rosa",
                State = "La Pampa",
                Phone = "+54-2954-813530"
            };
        }
        private static List<Experience> GenerateRealExperiences()
        {
            List<Experience> e = new List<Experience>
            {
                new Experience
                {
                    Title = "SEMPRE",
                    EndTitleData = "2022-Present",
                    SubTitle = "Developer Full-Stack and Junior Analyst, helped with the migration of web-based applications.",
                    Description = "",
                    Items = new List<string>
                    {
                        "Not only made the necesary changes on migration, but added better user experience with design.",
                        "Applied SCRUM Metodology for a strong comunication with clients and final users.",
                        "Made needed Rest API on .Net, and used the standard JSON Web Token Bearer Security.",
                        "Wrote Object Oriented generic code, for clean future modifications.",
                        "Worked with a specialiced repository like GitHub based IDE."
                    }
                },
                new Experience
                {
                    Title = "",
                    EndTitleData = "",
                    SubTitle = "Made a Accounting & Afiliate web application, understanding legacy Dbs, adapting to new standards.",
                    Description = "",
                    Items = new List<string>
                    {
                        "Develop funcionallity to consume a SOAP HTTP Web-Service.",
                        "Made dynamic PDF and Excel Reports.",
                        "Created proceses to process legacy files, like old csv reports and other types.",
                        "Learned to create, export and modify tables, with high data quantity.",
                    }
                },
                new Experience
                {
                    Title = "EDUCATION",
                    EndTitleData = "2020-2024",
                    SubTitle = "COMPUTER SCIENCE",
                    Description = "EN: Higher technician in software development - ES: Tecnico superior en Desarrollo de Software",
                    Items = new List<string>
                    {
                        "Learned Object Oriented Code, with C#, implementing desing patterns and good code atomization.",
                        "Used broad diagrams types, like UML, DCU, ER, etc.",
                        "Irl practice with arduino and related robotic programs like proteus, tinkercad, etc.",
                        "Made inventory system divided on two parts, backend (API), and frontend (VUE)."
                    }
                },
                new Experience
                {
                    Title = "",
                    EndTitleData = "",
                    SubTitle = "Other Certificates",
                    Description = "",
                    Items = new List<string>
                    {
                        "Genexus 17 Junior Analyst",
                        "WorkWithPlus Analyst",
                        "SCRUM Certificate"
                    }
                },
                new Experience
                {
                    Title = "PROFICIENCIES",
                    EndTitleData = "",
                    SubTitle = "Worked with:",
                    Description = "POSTMAN, SOAP UI, DBeaver, Fork, Visual Studio, Arduino IDE, Visual Code, Draw.io, Genexus, Excel, VUE and related."
                }
,
                new Experience
                {
                    Title = "",
                    EndTitleData = "",
                    SubTitle = "Know the basic / Have an idea of:",
                    Description = "Docker, Linux, Business Inteligence using Visual Studio SSAS project, Android Studio, .NET MAUI, Windows Forms, Python, etc."
                },
                new Experience
                {
                    Title = "SKILLS & INTERESTS",
                    EndTitleData = "",
                    SubTitle = "",
                    Description = "Want to learn more about: SQL, .NET Framework, Linux, Docker, etc."
                },
                new Experience
                {
                    Title = "",
                    EndTitleData = "",
                    SubTitle = "",
                    Description = "Other: Like cats, practicing ceramic and want to perfect my english."
                }
            };


            return e;
        }

        private static List<Experience> GenerateExperiences()
        {
            List<Experience> experiences = new List<Experience>();

            for (int i = Random.Next(0, 10); i > 0; i--) experiences.Add(GenerateExperience());
            return experiences;
        }
        private static Experience GenerateExperience()
        {

            Experience experience;

            switch(Random.Next(1, 5))
            {
                case 1:
                    experience = new Experience
                    {
                        Title = Placeholders.Name(),
                        EndTitleData = Placeholders.ShortDate(),
                        SubTitle = Placeholders.Name(),
                        Description = Placeholders.LoremIpsum(),
                        Items = GetExperienceItem()
                    };
                    break;
                case 2:
                    experience = new Experience
                    {
                        Title = Placeholders.Name(),
                        EndTitleData = Placeholders.ShortDate(),
                        SubTitle = Placeholders.Name(),
                        Description = "",
                        Items = new List<string>()
                    };
                    break;
                case 3:
                    experience = new Experience
                    {
                        Title = Placeholders.Name(),
                        EndTitleData = "",
                        SubTitle = "",
                        Description = Placeholders.LoremIpsum(),
                        Items = GetExperienceItem()
                    };
                    break;
                case 4:
                    experience = new Experience
                    {
                        Title = "",
                        EndTitleData = Placeholders.ShortDate(),
                        SubTitle = Placeholders.Name(),
                        Description = Placeholders.LoremIpsum(),
                        Items = new List<string>()
                    };
                    break;
                case 5:
                    experience = new Experience
                    {
                        Title = Placeholders.Name(),
                        EndTitleData = Placeholders.ShortDate(),
                        SubTitle = "",
                        Description = "",
                        Items = GetExperienceItem()
                    };
                    break;
                default:
                    experience = new Experience
                    {
                        Title = "",
                        EndTitleData = "",
                        SubTitle = Placeholders.Name(),
                        Description = "",
                        Items = GetExperienceItem()
                    };
                    break;
            }
            return experience;
        }

        private static List<string> GetExperienceItem()
        {
            List<string> items = new List<string>();
            for (int i = 0; i < 3; i++) items.Add(Placeholders.Question());
            return items;
        }
        private static ContactData GenerateRandomContactData()
        {
            return new ContactData
            {
                Country = Placeholders.Name(),
                Mail = Placeholders.Email(),
                City = Placeholders.Label(),
                State = Placeholders.Label(),
                Phone = Placeholders.PhoneNumber()
            };
        }

    }
}
