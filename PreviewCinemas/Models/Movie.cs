using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreviewCinemas.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Genra { get; set; }
        public int year { get; set; }
        public string ImageURI { get; set; }


        public virtual ICollection<Showing> Showings { get; set; }

    }
}
