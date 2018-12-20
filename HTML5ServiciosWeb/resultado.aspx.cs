using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTML5ServiciosWeb
{
    public partial class resultado : System.Web.UI.Page
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public decimal Resultado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //GET
            //Numero1 = Convert.ToDecimal(HttpContext.Current.Request.QueryString[0]);
            //Numero2 = Convert.ToDecimal(Request.QueryString["n2"]);

            //POST
            Numero1 = Convert.ToDecimal(Request.Form["n1"]);
            Numero2 = Convert.ToDecimal(Request.Form["n2"]);

            //MIX DE GET Y POST
            //Numero1 = Convert.ToDecimal(Request.Params["n1"]);
            //Numero2 = Convert.ToDecimal(Request.Params["n2"]);


            Resultado = Numero1 + Numero2;
        }
    }
}