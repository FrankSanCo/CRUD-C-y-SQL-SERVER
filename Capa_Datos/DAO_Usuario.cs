using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Capa_Entidad;

namespace Capa_Datos
{
    public class DAO_Usuario
    {
        #region PATRON SINGLETON
        private static readonly DAO_Usuario _instancia = new DAO_Usuario();
        public static DAO_Usuario Instancia { get { return DAO_Usuario._instancia; } }
        #endregion

        public E_Usuario AccesoSistema(string User, string Pass)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            E_Usuario objUsuario = null;
            SqlDataReader dr = null;
            try
            {
                cn = Conexion.Instancia.ConectarBD();
                cmd = new SqlCommand("spAccesoSistema", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser",User);
                cmd.Parameters.AddWithValue("@prmPass",Pass);
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objUsuario = new E_Usuario();
                    objUsuario.Usuario = dr["Usuario"].ToString();
                    objUsuario.Password = dr["Password"].ToString();
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            return objUsuario;
        }
    }
}
