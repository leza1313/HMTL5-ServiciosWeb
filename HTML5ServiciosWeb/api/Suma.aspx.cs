using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTML5ServiciosWeb.api
{
    public partial class Suma : System.Web.UI.Page
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public decimal Resultado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //POST
            Numero1 = Convert.ToDecimal(HttpContext.Current.Request.Form["n1"]);
            Numero2 = Convert.ToDecimal(Request.Form["n2"]);
            Resultado = Numero1 + Numero2;

            Response.Write(Resultado.ToString("N2"));
        }
    }
}