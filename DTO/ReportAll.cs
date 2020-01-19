using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTiw.DTO
{
    class ReportAll
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public float CostPrice { get; set; }
        public float ProductPrice { get; set; }
        public float Counts { get; set; }
        public float TotalCost { get; set; }
        public float TotalRevenue { get; set; }
    }
}
