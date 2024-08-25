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
                Experience = GenerateExperiences()
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
