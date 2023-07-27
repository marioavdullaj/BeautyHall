using BeautyHall.Api.SDK.Responses;
using BSMS.Winforms.Models;
using DevExpress.DataAccess.Json;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
namespace BSMS.Winforms.Utils
{
    public static class PrintUtils
    {
        public static string GenerateReportString(Order? order, IEnumerable<Service> services)
        {
            List<ReportOrder> report = new();
            foreach (Service service in services)
            {
                var paymentSummary = order?.PaymentSummaries?.FirstOrDefault();
                var reportOrder = new ReportOrder
                {
                    Name = $"{order?.Customer?.SubjectLastName} {order.Customer?.SubjectName}",
                    Phone = order?.Customer?.PhoneNumber,
                    Email = order?.Customer?.Email,
                    ServiceId = service.ServiceId,
                    ServiceDescription = service.ServiceDescription,
                    TotalCash = paymentSummary != null ? paymentSummary.TotalCash : 0,
                    TotalPOS = paymentSummary != null ? paymentSummary?.TotalPOS : 0,
                    DiscountedPrice = paymentSummary != null ? paymentSummary.DiscountedPrice : 0
                };

                var orderService = order?.OrderServices?.Where(x => x.ServiceId == service.ServiceId).FirstOrDefault();
                if(orderService != null)
                {
                    reportOrder.Price = orderService.ServicePrice;
                    reportOrder.EmployeeCode = orderService.Employee?.EmployeeCode;
                }

                report.Add(reportOrder);
            }
            return Newtonsoft.Json.JsonConvert.SerializeObject(report);
        }
        public static bool GenerateRpt(string reportData, string? reportPath = "", string exportPath = "")
        {
            try
            {
                JsonDataSource jsDs = getJsonSource(reportData.ToString());
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
