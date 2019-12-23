using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTiw
{
    
    public class OrderDetail
    {
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int Amount { get; set; }
        public float Total
        {
            get
            {
                return Amount * ProductPrice;
            }
        }
    }
}
