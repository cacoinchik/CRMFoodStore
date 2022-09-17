using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMData.Models.StockData
{
    public class StockProduct : Product
    {
        public double Weight { get; set; }
        public string Provider { get; set; }

    }
}
