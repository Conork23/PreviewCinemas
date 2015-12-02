using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewCinemas.Models
{
    public class Screen
    {
        
        public int ScreenID { get; set; }
        public int ScreenNumber { get; set; }
        public int Seats { get; set; }


        public virtual ICollection<Showing> Showings { get; set; }

    }
}

