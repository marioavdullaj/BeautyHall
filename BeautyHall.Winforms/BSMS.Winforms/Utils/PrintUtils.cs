using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.Models;
using DevExpress.DataAccess.Json;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
namespace BSMS.Winforms.Utils
{
    public static class PrintUtils
    {
        public static string GenerateReportDataSource(Order? order, IEnumerable<Service>? services = null)
        {
            List<ReportOrder> report = new();
            var name = $"{order?.Customer?.SubjectLastName} {order?.Customer?.SubjectName}";
            var phone = order?.Customer?.PhoneNumber;
            var email = order?.Customer?.Email;
            var paymentSummary = order?.PaymentSummaries?.FirstOrDefault();
            var totalCash = paymentSummary != null ? paymentSummary.TotalCash : 0;
            var totalPos = paymentSummary != null ? paymentSummary.TotalPOS : 0;
            var discountedPrice = paymentSummary != null ? paymentSummary.DiscountedPrice : 0;

            if (services != null && services.Any())
            {
                foreach (Service service in services)
                {
                    var reportOrder = new ReportOrder
                    {
                        Name = name,
                        Phone = phone,
                        Email = email,
                        ServiceId = service.ServiceId,
                        ServiceDescription = service.ServiceDescription,
                        TotalCash = totalCash,
                        TotalPOS = totalPos,
                        DiscountedPrice = discountedPrice
                    };

                    var orderService = order?.OrderServices?.Where(x => x.ServiceId == service.ServiceId).FirstOrDefault();
                    if (orderService != null)
                    {
                        reportOrder.Price = orderService.ServicePrice;
                        reportOrder.EmployeeCode = orderService.Employee?.EmployeeCode;
                    }
                    report.Add(reportOrder);
                }
            }
            else
            {
                foreach(var service in order?.OrderServices??new List<OrderService>())
                {
                    report.Add(new ReportOrder
                    {
                        Name = name,
                        Phone = phone,
                        Email = email,
                        ServiceId = service.ServiceId,
                        ServiceDescription = service.Service?.ServiceDescription,
                        EmployeeCode = service.Employee?.EmployeeCode,
                        Price = service?.ServicePrice,
                        TotalCash = totalCash,
                        TotalPOS = totalPos,
                        DiscountedPrice = discountedPrice
                    });
                }
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(report);
        }
        public static bool GenerateReportFile(string reportData, string? reportPath = "", string exportPath = "")
        {
            try
            {
                JsonDataSource jsDs = getJsonSource(reportData);
                XtraReport rpt = GetReport(reportPath??"", jsDs);
                rpt.ShowPrintMarginsWarning = false;
                rpt.ShowPrintStatusDialog = false;
                PdfExportOptions options = rpt.ExportOptions.Pdf;
                options.PdfACompatibility = PdfACompatibility.None;
                options.ExportEditingFieldsToAcroForms = true;
                options.ConvertImagesToJpeg = false;
                options.ImageQuality = PdfJpegImageQuality.High;
                rpt.ExportToPdf(exportPath, options);
            }
            catch 
            { 
                return false; 
            }
            return true;
        }

        public static bool GenerateReportsFile(string[] reportData, string? reportPath = "", string exportPath = "")
        {
            try
            {
                XtraReport report1 = GetReport(reportPath??"", getJsonSource(reportData[0]));
                report1.ShowPrintMarginsWarning = false;
                report1.ShowPrintStatusDialog = false;

                for(int i = 1; i < reportData.Length; i++)
                {
                    XtraReport report2 = GetReport(reportPath ?? "", getJsonSource(reportData[i]));
                    report2.ShowPrintMarginsWarning = false;
                    report2.ShowPrintStatusDialog = false;
                    report1.ModifyDocument(x => x.AddPages(report2.Pages));
                }

                PdfExportOptions options = report1.ExportOptions.Pdf;
                options.PdfACompatibility = PdfACompatibility.None;
                options.ExportEditingFieldsToAcroForms = true;
                options.ConvertImagesToJpeg = false;
                options.ImageQuality = PdfJpegImageQuality.High;
                report1.ExportToPdf(exportPath, options);
            }
            catch
            {
                return false;
            }
            return true;
        }
        private static JsonDataSource getJsonSource(string rptData)
        {
            try
            {
                return new JsonDataSource { JsonSource = new CustomJsonSource { Json = rptData } };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during the creation of the json datasource. Error: {ex.Message}");
            }
        }
        private static XtraReport GetReport(string rptFilename, JsonDataSource jsDs, string rptToMerge = "")
        {
            try
            {
                XtraReport rpt = XtraReport.FromFile(rptFilename);
                rpt.DataSource = jsDs;
                rpt.CreateDocument();
                return rpt;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error during the creation of the report: {ex.Message}");
            }
        }
    }
}
