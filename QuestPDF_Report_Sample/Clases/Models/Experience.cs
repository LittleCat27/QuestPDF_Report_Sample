using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestPDF_Report_Sample.Clases.Models
{
    public class Experience
    {
        public string? Title { get; set; }
        public string? EndTitleData { get; set; }
        public string? SubTitle { get; set; }
        public string? Description { get; set; }
        public List<string>? Items { get; set; }
    }
}
