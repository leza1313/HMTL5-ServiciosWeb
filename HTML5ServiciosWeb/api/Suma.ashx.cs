using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace HTML5ServiciosWeb.api
{
    /// <summary>
    /// Summary description for Suma1
    /// </summary>
    public class Suma1 : IHttpHandler
    {
        
        public void ProcessRequest(HttpContext context)
        {
            Operacion op = new Operacion();
            //POST
            op.Numero1 = Convert.ToDecimal(context.Request.Form["n1"]);
            op.Numero2 = Convert.ToDecimal(context.Request.Form["n2"]);
            op.Resultado = op.Numero1 + op.Numero2;

            string json = JsonConvert.SerializeObject(op);
            context.Response.ContentType = "text/plain";
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }

    public class Operacion
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public decimal Resultado { get; set; }
    }
}