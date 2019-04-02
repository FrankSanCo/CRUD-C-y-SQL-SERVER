using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
using Capa_Entidad;


namespace Capa_Presentacion
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            listarProdcuto(1);
        }
        public void listarProdcuto( Int16 estado)
        {
            List<E_Producto> listaProducto = N_Producto.Instancia.ConsultarProducto(estado);
             
            GridView1.DataSource = listaProducto;
            GridView1.DataBind();
           
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            E_Producto entProd = new E_Producto()
            {
                IdProducto = Convert.ToInt32(txtIdProducto.Text),
                NomProducto = txtNombreProducto.Text,
                Precio = Convert.ToDecimal(txtPrecio.Text),
                Estado = Convert.ToInt16(txtEstado.Text),

            };
            Int32 result = N_Producto.Instancia.insertProduct(entProd);
            if(result>0)
            {
                lblMensaje.Text = "Registro exitoso";
                listarProdcuto(1);
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            E_Producto buscarProducto = new E_Producto()
            {
                Estado = Convert.ToInt16(txtEstado.Text),
            };
           

           
        }
    }
}