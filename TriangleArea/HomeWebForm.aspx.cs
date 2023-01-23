using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibraryTriangleArea;


namespace TriangleArea
{
    public partial class HomeWebForm : System.Web.UI.Page
    {
        [WebMethod]
        public static string Result()
        {
            return "TTTTTTT";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("---- start ----- ");
            var kol =  new Models.AdapterProgram();

        }
    }
}