using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class N_Usuario
    {
        #region PATRON SINGLETON
        private static readonly N_Usuario _instancia = new N_Usuario();
        public static N_Usuario Instancia { get { return N_Usuario._instancia; } }
        #endregion

        public E_Usuario AccesoSistema(string User, string Pass)
        {
            E_Usuario usuario = null; 
            try
            {
                if (User!="" || Pass!="")
                {
                    usuario= DAO_Usuario.Instancia.AccesoSistema(User, Pass);
                }              
            }

            catch (Exception ex)
            {

                throw ex;
            }
            return usuario;
        }
    }
}
