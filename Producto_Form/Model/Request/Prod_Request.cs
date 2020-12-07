using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto_Form.Model.Request
{
    public class Prod_Request
    {
        public int idproducto { get; set; }
        public string nom_prod { get; set; }
        public Nullable<int> valor_producto { get; set; }
    }
}
