using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryTriangleArea;
using TriangleArea.Models;

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
            System.Diagnostics.Debug.WriteLine("---- end ----- " );

            ThreadMain threadMain = new ThreadMain();

            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "0paint.exe");
           
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("An element with Key = \"txt\" already exists.");
            }
            System.Diagnostics.Debug.WriteLine("For key = \"rtf\", value = {0}.", openWith["bmp"]);
            // var client = new HttpClient();
            ThreadWait.Main();
            ThreadMutex.Main();
            ThreadSemaphore.Main();
            ThreadCancelation.Main();
            ThreadDelegate.Main();
            TaskFactory.Main();
        }
      
    }
}