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
        public string? ProductDescription { get; set; }
        public string? SupplierId { get; set; }
        public DateTime? ProductRegistrationDate { get; set; }
        public decimal? SellingPrice { get; set; }

    }
}
