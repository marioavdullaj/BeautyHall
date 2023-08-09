using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSMS.Winforms.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductTitle { get; set; }
        public string? Supplier { get; set; }
        public DateTime? ProductRegistrationDate { get; set; }
        public decimal? Price { get; set; }

    }
}
