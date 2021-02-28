using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgramacionUno.Dominio
{
    class ClsEntidades
    {
        private string user;
        private string userPass;
        private string admin;
        private string adminUser;

        public string User { get => user; set => user = value; }
        public string UserPass { get => userPass; set => userPass = value; }
        public string Admin { get => admin; set => admin = value; }
        public string AdminUser { get => adminUser; set => adminUser = value; }
    }
}
