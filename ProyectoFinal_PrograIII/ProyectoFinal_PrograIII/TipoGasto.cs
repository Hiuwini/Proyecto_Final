using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PrograIII
{
    class TipoGasto
    {
        string codigo_gasto;
        string nombre_gasto;
        string tipo_gasto;

        public string Codigo_gasto
        {
            get
            {
                return codigo_gasto;
            }

            set
            {
                codigo_gasto = value;
            }
        }

        public string Nombre_gasto
        {
            get
            {
                return nombre_gasto;
            }

            set
            {
                nombre_gasto = value;
            }
        }

        public string Tipo_gasto
        {
            get
            {
                return tipo_gasto;
            }

            set
            {
                tipo_gasto = value;
            }
        }
    }
}
