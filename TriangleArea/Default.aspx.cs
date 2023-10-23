using LibraryTriangleArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace TriangleArea
{
    public partial class _Default : Page
    {
        [WebMethod]
        public static string CreateReport()
        {
            return "CreateReport     TTTT";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                HttpCookieCollection myCol = Request.Cookies;

                // Считаем площадь через веб форму.
                string result = TriangleAreaSpace.TrianglrAreaS(Double.Parse(Request.Form["aCathetus"]), Double.Parse(Request.Form["bCathetus"]), Double.Parse(Request.Form["hipotenuse"]));

                result = "<h3>" + result + "</h3>";

                // Отправляем результат.
                PlaceHolder1.Controls.Add(new LiteralControl(result));
            }
            else
            {
                
            }
            XmlDocument doc = new XmlDocument();
            System.Diagnostics.Debug.WriteLine("  Default  = "+ doc.ToString());
            /*
            using(var a = new object())
            {
                System.Diagnostics.Debug.WriteLine("  Def  = " );
            }
            */
        }
    }
}