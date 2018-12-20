using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTML5ServiciosWeb
{
    public partial class Default : System.Web.UI.Page
    {
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Nombre = "Borja";
            Numero = 4;
            Fecha = DateTime.Now;

        }
    }
}