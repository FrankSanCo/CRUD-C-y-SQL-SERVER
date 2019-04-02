using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class DAO_Producto
    {
        #region PATRON SINGLETON
        private static readonly DAO_Producto _instancia = new DAO_Producto();
        public static DAO_Producto Instancia { get { return DAO_Producto._instancia; } }
        #endregion

      public Int32 insertProduct(E_Producto entProd)
      {

            SqlConnection cn = null;
            SqlCommand cmd = null;
            Int32 finalResult = 0;

            try
            {
                cn = Conexion.Instancia.ConectarBD();
                cmd = new SqlCommand("Producto_Insert_Update_sp",cn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramCodRetorno = new SqlParameter("@productoOutput", SqlDbType.Int);
                paramCodRetorno.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramCodRetorno);

                cmd.Parameters.AddWithValue("@prmIdProd", entProd.IdProducto);
                cmd.Parameters.AddWithValue("@prmNombreProd",entProd.NomProducto);
                cmd.Parameters.AddWithValue("@prmPrecio",entProd.Precio);
                cmd.Parameters.AddWithValue("@prmEstado",entProd.Estado);

                cn.Open();
                finalResult = cmd.ExecuteNonQuery();
                if(finalResult > 0)
                {
                    if(entProd.IdProducto==0)
                    {
                        finalResult= Convert.ToInt32(cmd.Parameters["@productoOutput"].Value);
                    }
                }
             
            }
            catch (Exception ex)
            {
                finalResult = 0;
                throw;
            }
            finally
            {
                cn.Close();
            }
            return finalResult;
      }

        public List<E_Producto> ConsultarProducto(Int16 estado)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            E_Producto objProducto = null;
            List<E_Producto> lista = new List<E_Producto>();
            try
            {         

                cn = Conexion.Instancia.ConectarBD();
                cmd = new SqlCommand("Producto_Listar_sp", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmEstado", estado);

                cn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    objProducto = new E_Producto()
                    {
                        IdProducto = Convert.ToInt32(dr["IdProducto"]),
                        NomProducto = dr["NombreProd"].ToString(),
                        Precio = Convert.ToDecimal(dr["Precio"]),
                        Estado = Convert.ToInt16(dr["estado"])
                    };
                    lista.Add(objProducto);
                }

            }
            catch (Exception ex)
            {
                lista = null;
                throw;
            }
            finally
            {
                cn.Close();
            }
            return lista;
            
        }
        
    }
}
