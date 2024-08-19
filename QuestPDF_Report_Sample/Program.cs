
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPDF.Helpers;
using QuestPDF_Report_Sample.Clases;

QuestPDF.Settings.License = LicenseType.Community;


//var model = InvoiceDocumentDataSource.GetInvoiceDetails();
//var document = new InvoiceDocument(model);
//document.ShowInPreviewer();

var model2 = ResumeDocumentDataSource.GetResumeDetails();
var document2 = new ResumeDocument(model2);
document2.ShowInPreviewer();