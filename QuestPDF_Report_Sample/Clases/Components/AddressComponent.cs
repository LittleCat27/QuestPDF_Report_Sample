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
    public class AddressComponent : IComponent
    {
        private string Title { get; set; }
        private Address Address { get; set; }

        public AddressComponent(string title, Address address)
        {
            Title = title;
            Address = address;
        }
        public void Compose(IContainer container)
        {
            container.Table(t =>
            {
                t.ColumnsDefinition(c =>
                {
                    c.RelativeColumn();
                    c.RelativeColumn();
                });
                t.Cell().Text("Nombre: ");
                t.Cell().Text(Address.CompanyName);
                t.Cell().Text("Dirección: ");
                t.Cell().Text(Address.Street);



            });
            //container.Background(Colors.Grey.Lighten1).Placeholder();

            //container.Column(c => //TODO Hacer que Los datos queden alineados
            //{
            //    c.Spacing(2);
            //    c.Item().BorderBottom(1).PaddingBottom(3).Text(this.Title).SemiBold();
            //    c.Item().Text($"Nombre: {Address.CompanyName}");
            //    c.Item().Text($"Dirección: {Address.Street}");
            //    c.Item().Text($"{Address.City}, {Address.State}");
            //    c.Item().Text($"Mail: {Address.Email}");
            //    c.Item().Text($"Telefono: {Address.Phone}");
            //});
        }
    }
}
