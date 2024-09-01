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
        private Experience Experience { get; set; }

        public ExperienceComponent(Experience experience)
        {
            Experience = experience;
        }
        public void Compose(IContainer container)
        {
            container.Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    if (Experience.Title != null && Experience.Title.Length > 0)
                        column.Item().Row(subRow =>
                        {
                            subRow.RelativeItem().Text(Experience.Title).Bold().FontSize(12).Underline();
                            subRow.AutoItem().AlignLeft().Text(Experience.EndTitleData).FontSize(12);
                        });

                    if(Experience.SubTitle != null && Experience.SubTitle.Length > 0)
                        column.Item().Padding(4).Text(Experience.SubTitle).Bold();

                    if(Experience.Description != null && Experience.Description.Length > 0)
                        column.Item().Padding(4).Text(Experience.Description);


                    if (Experience.Items != null)
                        foreach (string item in Experience.Items)
                            column.Item().PaddingLeft(10).Row(subRow =>
                            {
                                subRow.AutoItem().Text("*   ").Bold();
                                subRow.RelativeItem().Text($"{item}");
                            });
                });
            });

        }
    }
}
