using LibraryTriangleArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TriangleArea
{
    public partial class _Default : Page
    {
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
        }
    }
}