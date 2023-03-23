using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryTriangleArea;


namespace TriangleArea
{
    public partial class HomeWebForm : System.Web.UI.Page
    {
        public enum Route { Home, Web, Triangle };
        IEnumerable<string> RouteList;

        [WebMethod]
        public static string Result()
        {
            return "TTTTTTT";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            RouteList = new[] { Route.Home.ToString(), Route.Web.ToString() } ;

            RouteList = new List<string>() { Route.Home.ToString(), Route.Web.ToString(), Route.Triangle.ToString()};

         

            System.Diagnostics.Debug.WriteLine("---- start ----- "+ Route.Home.ToString());
            var adapter=  new Models.AdapterProgram();



           // var client = new HttpClient();
        }
      
    }
}