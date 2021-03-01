using LaboratorioProgramacionUno.DAO;
using LaboratorioProgramacionUno.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Negocio
{
    class ClsLoginAdmin
    {
        ClsUsuarios clsUser = new ClsUsuarios();
        ClsAdministradores clsAdmin = new ClsAdministradores();
        public bool accesoAdmin(ClsEntidades entidad)
        {
            bool estado = false;

            clsAdmin.administradores = clsAdmin.administradores.Distinct().ToArray();
            clsAdmin.adminPasswords = clsAdmin.adminPasswords.Distinct().ToArray();

            for (int i = 0; i < clsUser.usuarios.Length; i++)
            {
                if (entidad.Admin.Equals(clsAdmin.administradores[i]) && entidad.AdminPass.Equals(clsAdmin.adminPasswords[i]))
                {
                    estado = true;
                }
            }

            return estado;

        }
    }
}
