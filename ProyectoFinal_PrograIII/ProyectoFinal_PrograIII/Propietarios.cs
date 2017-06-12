using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PrograIII
{
    class Propietarios
    {
        string nombre_propietario;
        string nit_propietario;
        string email_propietario;

        public string Nombre_propietario
        {
            get
            {
                return nombre_propietario;
            }

            set
            {
                nombre_propietario = value;
            }
        }

        public string Nit_propietario
        {
            get
            {
                return nit_propietario;
            }

            set
            {
                nit_propietario = value;
            }
        }

        public string Email_propietario
        {
            get
            {
                return email_propietario;
            }

            set
            {
                email_propietario = value;
            }
        }
    }
}
