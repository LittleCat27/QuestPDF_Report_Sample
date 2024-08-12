using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF_Report_Sample.Clases.Models;

namespace QuestPDF_Report_Sample.Clases.Components
{
    public class ExperienceComponent : IComponent
    {
        private string Title { get; set; }
        private Experience Experience { get; set; }

        public ExperienceComponent(string title, Experience experience)
        {
            Title = title;
            Experience = experience;
        }
        public void Compose(IContainer container)
        {
            //container.Table(t =>
            //{
            //    t.ColumnsDefinition(c =>
            //    {
            //        c.RelativeColumn();
            //        c.RelativeColumn();
            //    });
            //    t.Cell().Text("Nombre: ");
            //    t.Cell().Text(Address.CompanyName);
            //    t.Cell().Text("Dirección: ");
            //    t.Cell().Text(Address.Street);



            //});

        }
    }
}
