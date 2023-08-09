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
        public string ProductID { get; set; }
        public string ProductQuantity { get; set; }
        public DateTime? StockRegistrationDate { get; set; }

    }
}
