using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using HTML5ServiciosWeb.models;

namespace HTML5ServiciosWeb.api.northwind
{
    /// <summary>
    /// Summary description for orders
    /// </summary>
    public class orders : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            ModelNorthwind db = new ModelNorthwind();
            db.Configuration.LazyLoadingEnabled = false;

            string id = context.Request.Params["id"];
            var pedidos = db.Orders
                .Where(r => r.CustomerID == id)
                .Select(s=> new
                {
                    OrderID= s.OrderID,
                    EMPRESA = s.Customers.CompanyName,
                    ShipCity = s.ShipCity,
                    ShipCountry = s.ShipCountry,
                    ShippedDate = s.ShippedDate,
                    IMPORTE = s.Order_Details.Sum(t => t.Quantity * t.UnitPrice),
                    /*importe2 = db.Order_Details
                        .Where(x => x.OrderID == s.OrderID)
                        .Sum(y => y.Quantity * y.UnitPrice)
                    */
                })
                .ToList();
            

            string json =JsonConvert.SerializeObject(pedidos);
            context.Response.ContentType = "text/json";
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
}