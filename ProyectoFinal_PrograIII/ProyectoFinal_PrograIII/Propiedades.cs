using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PrograIII
{
    class Propiedades
    {
        string tipo_propiedad;
        string codigo_propiedad;
        int metros_propiedad;
        string nit_propietario;
        string porcentaje_gasto;
        string infoespe1;
        string infoespe2;

        public string Tipo_propiedad
        {
            get
            {
                return tipo_propiedad;
            }

            set
            {
                tipo_propiedad = value;
            }
        }

        public string Codigo_propiedad
        {
            get
            {
                return codigo_propiedad;
            }

            set
            {
                codigo_propiedad = value;
            }
        }

        public int Metros_propiedad
        {
            get
            {
                return metros_propiedad;
            }

            set
            {
                metros_propiedad = value;
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

        public string Porcentaje_gasto
        {
            get
            {
                return porcentaje_gasto;
            }

            set
            {
                porcentaje_gasto = value;
            }
        }

        public string Infoespe1
        {
            get
            {
                return infoespe1;
            }

            set
            {
                infoespe1 = value;
            }
        }

        public string Infoespe2
        {
            get
            {
                return infoespe2;
            }

            set
            {
                infoespe2 = value;
            }
        }
    }
}
