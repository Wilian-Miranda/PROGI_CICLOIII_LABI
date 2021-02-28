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
        public int accesoAdmin(ClsEntidades entidad)
        {
            int estado = 0;

            clsAdmin.administradores = clsAdmin.administradores.Distinct().ToArray();
            clsAdmin.adminPasswords = clsAdmin.adminPasswords.Distinct().ToArray();

            for (int i = 0; i < clsUser.usuarios.Length; i++)
            {
                if (entidad.Admin.Equals(clsAdmin.administradores[i]) && entidad.AdminPass.Equals(clsAdmin.adminPasswords[i]))
                {
                    estado = 2;
                }
            }

            return estado;

        }
    }
}
