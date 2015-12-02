using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewCinemas.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date_Of_Order { get; set; }


        public virtual Cart Cart { get; set; }
    }
}
