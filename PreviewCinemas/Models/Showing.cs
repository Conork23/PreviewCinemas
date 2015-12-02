using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewCinemas.Models
{
    public class Showing
    {
        public int ShowingID { get; set; }
        public int MovieID { get; set; }
        public int ScreenID { get; set; }
        public DateTime DateAndTime { get; set; }
        public double Price { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Screen Screen { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }

    }
}
