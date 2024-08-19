using QuestPDF.Drawing;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF_Report_Sample.Clases.Components;
using QuestPDF_Report_Sample.Clases.Models;

public class ResumeDocument : IDocument
{
    public ResumeModel Model { get; }

    public ResumeDocument(ResumeModel model)
    {
        Model = model;
    }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;
    public DocumentSettings GetSettings() => DocumentSettings.Default;


    public void Compose(IDocumentContainer container)
    {
        container
            .Page(page =>
            {
                page.Margin(20);

                page.Header().Element(ComposeHeader);
                page.Content().Element(ComposeContent);
            });
    }
    void ComposeContent(IContainer container)
    {
        container.PaddingVertical(0).Column(column =>
        {
            column.Item().Text(text =>
            {
                text.Span("WORK EXPERIECE").ExtraBold().Underline().FontSize(16);
            });
            column.Spacing(5);
            if (Model.Experience != null)
                foreach (Experience experience in Model.Experience)
                    column.Item().Component(new ExperienceComponent(experience));

        });
    }
    void ComposeHeader(IContainer container)
    {
        var titleStyle = TextStyle.Default.FontSize(16).SemiBold();

        container.Row(row =>
        {
            row.RelativeItem().Column(column =>
            {
                column.Item().AlignCenter().Text($"{Model.FullName}").Style(titleStyle);

                column.Item().AlignCenter().Text(text =>
                {
                    if (Model.ContactData != null)
                        text.Span($"{Model.ContactData.Mail} | {Model.ContactData.City}, {Model.ContactData.Country} | {Model.ContactData.Phone}").FontSize(14);
                    
                });
                column.Item().PaddingVertical(10).BorderBottom(1).BorderColor(Colors.Black);

            });
        });
    }



 



}