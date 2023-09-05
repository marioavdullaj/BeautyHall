using BeautyHall.Api.SDK.Responses;
using DevExpress.XtraScheduler.iCalendar.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS.Winforms.Models
{
    public class StockProducts
    {
        public int StockId { get; set; }
        public int ProductID { get; set; }
        public decimal ProductQuantity { get; set; }
        public DateTime? StockRegistrationDate { get; set; }
        public Product? Product { get; set; } = null;

    }
}
