using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTiw
{
    public class OrderDTO
    {
        public string ReceiptID { get; set; }
        public string ReceiptDate { get; set; }
        public string ReceiptTime { get; set; }
        public string TotalPrice { get; set; }
        public string ProductAmount { get; set; }
        public string Active { get; set; }
    }
}
