using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace PreviewCinemas.Models
{
    /// <summary>
    /// Summary description for CinemaServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class CinemaServices : System.Web.Services.WebService
    {
        private CinemaContext entities = new CinemaContext();



        [WebMethod]
        
        public string[] GetShowings(string namePart)
        {
            List<string> showings = new List<string>();

            foreach (var item in entities.Showings.Where(m => m.Movie.Title.Equals(namePart)))
            {
               
                    showings.Add(item.DateAndTime.ToString());
                 
            }

            return showings.ToArray();
        }

    }
}
