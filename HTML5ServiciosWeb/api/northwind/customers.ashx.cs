using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HTML5ServiciosWeb.models;
using Newtonsoft.Json;

namespace HTML5ServiciosWeb.api.northwind
{
    /// <summary>
    /// Consulta de la tabla de clientes
    /// </summary>
    public class customers : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            ModelNorthwind db = new ModelNorthwind();
            db.Configuration.LazyLoadingEnabled = false;

            string id = context.Request.Params["id"];

            var resul = db.Customers.Where(r => r.CustomerID == id).FirstOrDefault();
            //context.Response.Write(resul.ContactName);

            if (resul!=null)
            {
                string json1 = JsonConvert.SerializeObject(resul);
                context.Response.ContentType = "text/json";
                context.Response.Write(json1);
            }
            else
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write("No existe el cliente");
            }
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}