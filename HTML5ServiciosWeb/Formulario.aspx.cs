using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTML5ServiciosWeb
{
    public partial class Formulario : System.Web.UI.Page
    {
        public decimal Resultado { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            decimal n1 = Convert.ToDecimal(Request.Form["n1"]);
            decimal n2 = Convert.ToDecimal(Request.Form["n2"]);

            Resultado = n1 + n2;
        }
    }
}