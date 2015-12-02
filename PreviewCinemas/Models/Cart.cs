using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewCinemas.Models
{
    public class Cart
    {

        
        public int CartID { get; set; }
        public int ShowingID { get; set; }
        public int Quantity { get; set; }


        public virtual Showing Showing { get; set; }

       
    }
}
