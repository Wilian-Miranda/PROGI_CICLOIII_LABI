using LaboratorioProgramacionUno.DAO;
using LaboratorioProgramacionUno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Negocio
{
    class ClsLogin
    {
        ClsUsuarios clsUser = new ClsUsuarios();
        ClsAdministradores clsAdmin = new ClsAdministradores();
        public int acceso(ClsEntidades entidad)
        {
            int estado = 0;

            clsUser.usuarios = clsUser.usuarios.Distinct().ToArray();
            clsUser.userPasswords = clsUser.userPasswords.Distinct().ToArray();

            for (int i = 0; i < clsUser.usuarios.Length; i++)
            {
                if (entidad.User.Equals(clsUser.usuarios[i]) && entidad.UserPass.Equals(clsUser.userPasswords[i]))
                {
                    estado = 1;
                }

                if (entidad.Admin.Equals(clsAdmin.administradores[i]) && entidad.AdminPass.Equals(clsAdmin.adminPasswords[i]))
                {
                    estado = 2;
                }

            }

            return estado;

        }
    }
}
