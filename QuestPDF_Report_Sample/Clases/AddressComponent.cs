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
using QuestPDF_Report_Sample.Clases;


namespace QuestPDF_Report_Sample.Clases
{
    public class AddressComponent : IComponent
    {
        private string Title { get; set; }
        private Address Address { get; set; }

        public AddressComponent(string title, Address address)
        {
            this.Title = title;
            this.Address = address;
        }
        public void Compose(IContainer container)
        {
            container.Column(c => //TODO Hacer que Los datos queden alineados
            {
                c.Spacing(2);
                c.Item().BorderBottom(1).PaddingBottom(3).Text(this.Title).SemiBold();
                c.Item().Text($"Nombre: {Address.CompanyName}");
                c.Item().Text($"Dirección: {Address.Street}");
                c.Item().Text($"{Address.City}, {Address.State}");
                c.Item().Text($"Mail: {Address.Email}");
                c.Item().Text($"Telefono: {Address.Phone}");
            });
        }
    }
}
