using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class ProductoController : ApiController
    {
        [HttpPost]
        public IHttpActionResult agregar(Models.Request.Prod_Request model) {
            using (Models.VentasDWEntities1 db = new Models.VentasDWEntities1()) {

                var oProducto = new Models.Producto_v2();
                oProducto.idproducto = model.idproducto;
                oProducto.nom_prod = model.nom_prod;
                oProducto.valor_producto = model.valor_producto;
                db.Producto_v2.Add(oProducto);
                db.SaveChanges();
            }
            return Ok("Exito");
           }
        }
     }
