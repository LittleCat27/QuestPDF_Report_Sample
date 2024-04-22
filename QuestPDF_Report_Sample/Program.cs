
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using QuestPDF.Helpers;
using QuestPDF_Report_Sample.Clases;

QuestPDF.Settings.License = LicenseType.Community;


var model = InvoiceDocumentDataSource.GetInvoiceDetails();
var document = new InvoiceDocument(model);
document.ShowInPreviewer();