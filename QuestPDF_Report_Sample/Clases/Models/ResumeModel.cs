using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPDF_Report_Sample.Clases.Models
{
    public class ResumeModel
    {
        public string? FullName {  get; set; }
        public ContactData? ContactData { get; set; }
        public List<Experience>? Experience { get; set; }

    }
}
