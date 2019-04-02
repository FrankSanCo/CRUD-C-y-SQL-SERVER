using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class N_Producto
    {
        #region PATRON SINGLETON
        private static readonly N_Producto _instancia = new N_Producto();
        public static N_Producto Instancia { get { return N_Producto._instancia; } }
        #endregion

        public Int32 insertProduct(E_Producto entProd)
        {
            Int32 resultado = 0;
            try
            {
                if (entProd!=null)
                {
                    resultado= DAO_Producto.Instancia.insertProduct(entProd);
                }                
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }

        public List<E_Producto> ConsultarProducto(Int16 estado)
        {
            return DAO_Producto.Instancia.ConsultarProducto(estado);
        }
    }
}
