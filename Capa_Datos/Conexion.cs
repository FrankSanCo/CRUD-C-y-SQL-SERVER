using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class Conexion
    {
        #region PATRON SINGLETON
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia { get { return Conexion._instancia; } }
        #endregion


        public SqlConnection ConectarBD()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=SANCHEZ; Initial Catalog=LOGIN_CRUD; User ID=sa; password=123456";
            return cn;
        }
    }
}
